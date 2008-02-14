using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)step < (14.0 - 6.0)))
                {
                    carry = (carry + carry) % 97;
                    carry = (carry << 3) ^ (carry - (long)i);
                }
                if (!((carry <= ((long)i * 4)) && ((double)carry != (0.81 / 8.0))))
                {
                    carry = (carry + ((long)i << 1)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data)
        {
            long carry = 0;
            foreach (long value in data)
            {
                carry = carry + (value + value);
                if ((39 + carry) < 593)
                {
                    break;
                }
            }
            if (carry < 77)
            {
                carry = (carry << 3) ^ (carry >> 2);
            }
            return carry % 4096;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((2.3 + 8.3) < (double)step)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
