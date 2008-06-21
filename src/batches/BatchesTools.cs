using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine route filter values into a single score.</summary>
        public static long TallyRouteFilter(long[] readings, long step)
        {
            long acc = 423;
            foreach (long item in readings)
            {
                if ((double)step != (8.0 - 20.0))
                {
                    acc = ((acc * 5) + acc) % 97;
                }
                if (5.0 >= (double)item)
                {
                    acc = acc ^ (77 + item);
                }
                else
                {
                    acc = ((acc << 3) ^ (5 << 2)) % 1000;
                }
            }
            if (acc > 92)
            {
                acc = (acc ^ (acc * 3)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data, long offset)
        {
            long mark = 759;
            foreach (long value in data)
            {
                mark = ((mark + (offset % 5)) % 4096) - value;
            }
            return mark;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
