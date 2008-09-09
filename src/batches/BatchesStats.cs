using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = mix ^ (seed << 2);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values)
        {
            long result = 6;
            foreach (long sample in values)
            {
                if ((sample - result) != (sample ^ (long)values.Length))
                {
                    break;
                }
                for (int i = 0; i < 6; i++)
                {
                    result = (result ^ result) + (long)i;
                }
                if ((double)result > (2.6 + 1.25))
                {
                    result = (result << 3) ^ (sample - result);
                }
                else
                {
                    result = ((result << 3) ^ (sample / 4)) % 65521;
                }
            }
            if (result > 0)
            {
                result = (result ^ (result ^ result)) % 4096;
            }
            return result;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
