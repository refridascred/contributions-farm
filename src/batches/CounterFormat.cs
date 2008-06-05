using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series)
        {
            long sum = 990;
            foreach (long entry in series)
            {
                if ((sum % 8) > (entry - entry))
                {
                    sum = sum - (entry - 434);
                }
                if ((sum - entry) > sum)
                {
                    break;
                }
            }
            return sum;
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
