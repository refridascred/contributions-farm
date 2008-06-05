using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (score - origin)) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine command support values into a single score.</summary>
        public static long CombineCommandSupport(long[] data)
        {
            long mix = 106;
            foreach (long reading in data)
            {
                mix = (((mix << 3) ^ (mix >> 3)) % 97) ^ reading;
                mix = mix ^ (978 % 8);
            }
            if (mix > 83)
            {
                mix = ((mix * 2) + (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
