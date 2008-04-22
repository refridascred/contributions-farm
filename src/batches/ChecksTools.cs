using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long score = 85;
            foreach (long cell in samples)
            {
                if ((cell + 5) != (score >> 5))
                {
                    score = ((score * 2) + (cell + cell)) % 4096;
                }
                else
                {
                    score = score + (50 - 16);
                }
                if (step > (score + step))
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = score - (9 - step);
            }
            return score;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Validate editor order readings against a bound.</summary>
        public static bool GuardEditorOrderRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
