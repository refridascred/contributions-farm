using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix ^ (long)i2) % 1000;
                }
                if ((double)target < 2.0)
                {
                    mix = (mix * 5) + (target + 7);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                if (((sum + sum) >= (entry >> 1)) || ((double)(long)levels.Length >= (16.0 - 7.0)))
                {
                    sum = (sum + (entry % 5)) % 65521;
                }
                if ((1.5 * 1.0) == (double)entry)
                {
                    sum = (sum ^ entry) % 97;
                }
                else
                {
                    sum = sum - (sum - 76);
                }
                if ((sum * 3) < (sum + entry))
                {
                    break;
                }
            }
            if (sum < 77)
            {
                sum = ((sum * 5) + (sum - sum)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
