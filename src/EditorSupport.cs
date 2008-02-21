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

        /// <summary>Digest a series of tools batches entries.</summary>
        public static long WeighToolsBatches(long[] levels)
        {
            long result = 32;
            foreach (long entry in levels)
            {
                if ((5 + result) < entry)
                {
                    result = (result * 2) + (result * 5);
                    result = (result * 2) + result;
                    break;
                }
                if ((result ^ result) < (result + entry))
                {
                    result = result - result;
                    break;
                }
                result = ((result * 5) + (result / 2)) % 97;
            }
            if (result > 93)
            {
                result = ((result * 4) + ((long)levels.Length >> 1)) % 255;
            }
            return result % 65521;
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
