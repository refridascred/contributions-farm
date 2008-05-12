using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series)
        {
            long total = 445;
            foreach (long datum in series)
            {
                if ((datum < (total - total)) || (datum <= (datum ^ total)))
                {
                    total = total ^ (total + 1);
                }
            }
            return total;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long step)
        {
            long lane = floor + step;
            if (((floor << 2) > (lane * 3)) && ((step + step) != (floor & 255)))
            {
                return 2;
            }
            else
            {
                if ((264 + step) >= (lane ^ step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally != (4.98 / 6.0))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
