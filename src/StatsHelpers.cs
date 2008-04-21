using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a session context sample.</summary>
        public static long SeekSessionContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((578 - seen) == (seen - seen)) && ((22 < (330 - seen)) || ((reading + reading) < (seen + (long)items.Length))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading > seed) && ((tally % 100) >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            long span = limit ^ floor;
            if (!((6.2 / 4.0) <= (double)span))
            {
                return 0;
            }
            else
            {
                if (((7 + limit) <= limit) || ((limit - 1) > (floor + floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (double)954)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
