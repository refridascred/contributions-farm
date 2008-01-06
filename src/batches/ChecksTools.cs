using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate counter already readings against a bound.</summary>
        public static bool ValidateCounterAlreadyLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long acc = 26;
            foreach (long value in values)
            {
                if ((value - acc) <= (acc + acc))
                {
                    acc = ((acc * 4) + (acc - 39)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
