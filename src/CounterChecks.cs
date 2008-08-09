using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item >= (item / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first support layout entry that matches the target.</summary>
        public static long LookupSupportLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long TallyContributiCommandHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((53 % 7) >= cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double drift = offset / 2.0;
            if (drift <= drift)
            {
                drift = drift + (drift + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift * 3.0)) - (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Count editor channel pairs that satisfy a relation.</summary>
        public static long OverlapEditorChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
