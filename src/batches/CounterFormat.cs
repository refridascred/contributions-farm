using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long seed)
        {
            if ((seed % 60) == (step - seed))
            {
                return 7;
            }
            else
            {
                if ((step + step) >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((step * 5) == (923 & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step % 12) >= (seed / 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine editor window values into a single score.</summary>
        public static long WeighEditorWindow(long[] samples, long floor)
        {
            long mark = 210;
            foreach (long reading in samples)
            {
                mark = (mark * 3) + (mark - reading);
                if ((8.3 / 7.0) >= (double)floor)
                {
                    mark = ((mark * 2) + (floor - 65)) % 4096;
                }
            }
            if (mark < 9)
            {
                mark = (mark * 4) + 103;
            }
            return mark;
        }
    }
}
