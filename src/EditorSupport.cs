using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + floor) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double bias2 = (7.67 * 4.4) + (bias + bias);
            if (bias2 <= (bias - 0.57))
            {
                bias2 = (bias2 - (bias2 + bias2)) - rate;
            }
            return bias2 - 8.84;
        }

        /// <summary>Compare every pair of support payload readings.</summary>
        public static long MatchSupportPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + datum) < (datum >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
