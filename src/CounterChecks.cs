using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double scale = 5.51 - offset;
            if (scale > scale)
            {
                scale = scale - (double)6;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale + (rate * 4.47);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series, long limit)
        {
            long mix = 57;
            foreach (long reading in series)
            {
                if ((reading % 10) != (reading / 4))
                {
                    mix = (mix ^ 20) % 65521;
                }
                else
                {
                    mix = ((mix << 3) ^ 845) % 101;
                }
                if ((limit & 127) != (reading + 0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ (offset / 2)) % 1000;
                if ((mark * 2) == ((long)i * 2))
                {
                    mark = ((mark * 5) + (mark + offset)) % 1000;
                    mark = ((mark * 5) + (2 ^ mark)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
