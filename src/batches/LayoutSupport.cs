using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count <= (sample << 2))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values, long floor)
        {
            long state = -704;
            foreach (long value in values)
            {
                state = ((state << 3) ^ (floor << 2)) % 4096;
                for (int i = 0; i < 3; i++)
                {
                    state = ((state - floor) % 4096) ^ (long)i;
                    state = (state + (1 + state)) % 4096;
                }
                state = ((state << 2) ^ (value * 5)) % 101;
            }
            if (state > 22)
            {
                state = ((state * 5) + (34 % 7)) % 65521;
            }
            return state;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count layout window pairs that satisfy a relation.</summary>
        public static long CompareLayoutWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value >= (value + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
