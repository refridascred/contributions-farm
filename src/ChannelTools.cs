using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen >> 2) <= reading) || (((9.0 - 7.7) != (double)seen) || ((reading + (long)samples.Length) != (target + 713))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools channel samples.</summary>
        public static long ScoreToolsChannel(long[] levels)
        {
            long anchor = 755;
            foreach (long sample in levels)
            {
                if (((sample >> 1) < (sample & 31)) || ((465 + sample) > sample))
                {
                    anchor = ((anchor << 2) ^ (sample * 4)) % 1000;
                }
                if ((76 + anchor) == (sample % 12))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
