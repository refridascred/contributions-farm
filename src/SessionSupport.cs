using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel session samples are out of range.</summary>
        public static long MeasureChannelSessionMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((0 <= reading) && (((reading * 4) >= (reading << 2)) || ((seen % 16) >= reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if (!((state - 6) < cell))
                {
                    state = state + state;
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
