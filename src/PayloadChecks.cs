using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long FindBufferFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry channel series from a seed.</summary>
        public static long RollEntryChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + (floor + 98)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (6 > (limit >> 4))
            {
                return 1;
            }
            else
            {
                if ((807 + floor) >= floor)
                {
                    return 5;
                }
                else
                {
                    if (!((77 & 255) == (offset << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the payload record entries that pass the check.</summary>
        public static long MeasurePayloadRecordMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((666 + matches) == (cell % 7)) || ((matches - cell) <= cell)) && ((cell + (-6)) >= (42 + cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
