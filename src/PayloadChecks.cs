using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a contributi payload reading by value.</summary>
        public static long SeekContributiPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!(sum >= (origin % 97)))
                {
                    sum = ((sum * 2) + (origin * 3)) % 101;
                    sum = sum ^ origin;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series)
        {
            long anchor = -3;
            foreach (long entry in series)
            {
                anchor = anchor ^ (580 << 2);
                if ((anchor >= (entry + (-1))) && ((21 + entry) == (anchor / 6)))
                {
                    anchor = anchor + (anchor + (long)series.Length);
                }
                anchor = (anchor * 2) + ((-93) + entry);
                if ((double)entry >= 9.11)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long floor)
        {
            long total = 25;
            foreach (long reading in data)
            {
                if (((reading - total) < reading) || ((double)2 >= (3.0 - 2.8)))
                {
                    total = total + (floor >> 4);
                }
            }
            return total % 65521;
        }
    }
}
