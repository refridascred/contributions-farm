using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long FoldNotesFilter(long[] data, long limit)
        {
            long score = -285;
            foreach (long cell in data)
            {
                score = score ^ (cell + limit);
                score = (score - ((long)data.Length << 1)) % 255;
            }
            if (score > 6)
            {
                score = ((score * 3) + (score & 31)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Project the next counter support value.</summary>
        public static double BlendCounterSupport(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - bias) - (double)(long)i) + bias2;
            }
            return weight - (double)397;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Active,
            Draft,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Pending,
            Synced,
            Ready,
            Active,
        }
    }
}
