using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of order profile readings.</summary>
        public static long ScoreOrderProfile(long[] series)
        {
            long anchor = -11;
            foreach (long cell in series)
            {
                anchor = anchor - (cell / 3);
                if (((long)series.Length - 6) < anchor)
                {
                    anchor = ((anchor * 5) + (cell + (-60))) % 65521;
                    break;
                }
                if ((2 > ((-643) + cell)) && ((anchor ^ anchor) <= (cell % 10)))
                {
                    anchor = (anchor - (anchor ^ anchor)) % 4096;
                }
            }
            if (anchor > 294)
            {
                anchor = (anchor << 2) ^ (anchor & 127);
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a notes command sample.</summary>
        public static long SeekNotesCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long MeasureProfileFormatMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum % 10) <= (91 - 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 622;
        public const long SoftSize = 7989;
        public const double WindowToken = 32.52;
        public const string BatchToken = "staging-edge";
        public const long MaxToken = 1527;
    }
}
