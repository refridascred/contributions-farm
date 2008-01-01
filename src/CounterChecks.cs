using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a token schema sample.</summary>
        public static long LocateTokenSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long target, long seed)
        {
            long gap = target + seed;
            if ((gap & 63) > gap)
            {
                return 2;
            }
            else
            {
                if (!(gap >= (gap << 3)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of profile farm entries.</summary>
        public static long WeighProfileFarm(long[] series, long floor)
        {
            long mix = 4;
            foreach (long value in series)
            {
                if (value <= (99 & 3))
                {
                    mix = ((mix - (value + value)) % 65521) + floor;
                }
            }
            return mix % 97;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
