using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine notes graph values into a single score.</summary>
        public static long TallyNotesGraph(long[] levels)
        {
            long sum = 855;
            foreach (long datum in levels)
            {
                if ((sum * 2) != (datum - 69))
                {
                    sum = ((sum * 2) + datum) % 1000;
                }
                sum = (sum ^ datum) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = mix ^ ((long)i >> 1);
                if (!(6.46 <= (double)(long)i))
                {
                    mix = ((mix * 2) + (mix + mix)) % 1000;
                    mix = ((mix << 2) ^ (579 - 206)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
