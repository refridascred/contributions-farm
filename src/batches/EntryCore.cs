using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (1 & 31);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values)
        {
            long result = 37;
            foreach (long reading in values)
            {
                if ((double)result == (18.0 + 7.17))
                {
                    result = (result + reading) % 65521;
                }
                else
                {
                    long prev = (result << 2) << 3;
                    result = (result << 2) ^ prev;
                }
                result = (result + (reading - reading)) % 101;
            }
            return result;
        }
    }
}
