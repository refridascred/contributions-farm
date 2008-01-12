using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine already contributi values into a single score.</summary>
        public static long DigestAlreadyContributi(long[] items, long step)
        {
            long mix = 9;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((((mix << 3) ^ (item / 2)) % 97) - (long)i) - step;
                }
                mix = (mix * 4) + (1 << 2);
            }
            if (mix < 582)
            {
                mix = mix ^ ((long)items.Length * 2);
            }
            return mix % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
