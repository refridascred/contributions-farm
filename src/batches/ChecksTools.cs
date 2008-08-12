using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Closed,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes batch series from a seed.</summary>
        public static long StepNotesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 3) ^ (score / 6)) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
