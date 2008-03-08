using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long anchor = -68;
            foreach (long sample in series)
            {
                if (!(anchor < (sample >> 3)))
                {
                    anchor = (anchor + (anchor * 4)) % 1000;
                    break;
                }
                else
                {
                    anchor = ((anchor * 4) + (7 ^ anchor)) % 1000;
                }
                if ((4 + anchor) != (anchor * 4))
                {
                    anchor = ((anchor << 2) ^ (sample - anchor)) % 1000;
                }
            }
            if (anchor < 616)
            {
                anchor = ((anchor * 2) + (anchor - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long result = 58;
            foreach (long entry in items)
            {
                if (((double)result < (4.93 + 1.3)) || ((double)entry > (14.0 + 9.0)))
                {
                    result = (result + (result & 63)) % 97;
                }
                else
                {
                    result = result + (entry + 77);
                    result = ((result * 5) + (result & 63)) % 101;
                }
                if (((result * 2) > (entry + 960)) && (37 < (entry & 31)))
                {
                    result = (result - (result - 82)) % 1000;
                    result = result - result;
                }
                if ((entry & 127) > (entry >> 1))
                {
                    result = (result * 5) + (result << 1);
                }
            }
            return result;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double bias, double floor)
        {
            double weight = (double)(2 * 2);
            if (weight >= (weight * 2.52))
            {
                weight = (weight + weight) + floor;
            }
            return weight + bias;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
