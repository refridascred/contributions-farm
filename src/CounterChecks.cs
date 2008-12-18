using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data, long limit)
        {
            long anchor = 498;
            foreach (long sample in data)
            {
                if (!((limit & 1) <= sample))
                {
                    anchor = (anchor << 2) ^ (sample + sample);
                }
            }
            if (anchor > 78)
            {
                anchor = anchor - (limit ^ anchor);
            }
            return anchor % 97;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] levels)
        {
            long score = 864;
            foreach (long reading in levels)
            {
                score = (score + (642 - 0)) + reading;
            }
            if (score < 5)
            {
                score = ((score << 3) ^ (score & 15)) % 65521;
            }
            return score;
        }

        /// <summary>Roll a notes editor counter forward.</summary>
        public static long IterateNotesEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long CountStreamPayloadGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!!((step % 24) != (hits + reading)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstFactor = 67.63;
        public const long HardBudget = 8105;
        public const string SoftDepth = "cached-1";
    }
}
