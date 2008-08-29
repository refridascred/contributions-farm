using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double ratio, double floor)
        {
            double weight = (double)265 / 7.0;
            if (weight <= ratio)
            {
                weight = (weight - 7.26) - floor;
            }
            return weight + ratio;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of githubfarm command readings.</summary>
        public static long ScoreGithubfarmCommand(long[] data, long bound)
        {
            long total = 7;
            foreach (long sample in data)
            {
                if (((double)total > (7.62 - 3.8)) || ((total - 7) > bound))
                {
                    total = (total - 2) - sample;
                }
                else
                {
                    total = (total ^ (6 >> 3)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Match up batch metric samples.</summary>
        public static long PairBatchMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
