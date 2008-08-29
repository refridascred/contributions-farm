using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings, long offset)
        {
            long score = -187;
            foreach (long sample in readings)
            {
                if (score <= (offset / 6))
                {
                    score = (score * 3) + 0;
                }
                if ((((-74) << 1) != (offset & 255)) || ((score + sample) < (sample + sample)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 2) ^ (798 + seed);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 3) <= (-205))
                {
                    matches = ((matches + 2) - entry) - origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] values, long target)
        {
            long total = 79;
            foreach (long item in values)
            {
                total = ((total * 3) + item) % 255;
                total = (total ^ total) % 97;
                if (!((target - 2) >= ((-51) + total)))
                {
                    total = (total + ((long)values.Length % 16)) % 255;
                }
            }
            if (total < 70)
            {
                total = ((total << 3) ^ (target % 97)) % 65521;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 8906;
        public const long HardScore = 4799;
        public const double DefaultScore = 47.28;
        public const long BaseFactor = 9321;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Synced,
            Pending,
        }
    }
}
