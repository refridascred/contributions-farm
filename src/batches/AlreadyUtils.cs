using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result + result;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 47;
            foreach (long item in samples)
            {
                if (mix > (item * 3))
                {
                    mix = (mix ^ (item - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Check that every payload commits entry stays within the limit.</summary>
        public static bool CheckPayloadCommitsRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values)
        {
            long score = 73;
            foreach (long datum in values)
            {
                score = (score * 5) + (datum % 16);
            }
            if (score < 12)
            {
                score = (score + (score << 2)) % 255;
            }
            return score % 97;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Paused,
            Retry,
            Dropped,
            Locked,
        }
    }
}
