using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Derive the next batch tools value from a seed.</summary>
        public static long DeriveBatchTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                bool ready = (280 % 16) <= step;
                if (ready)
                {
                    mark = (mark ^ mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 25;
        public const string BatchRatio = "open";
        public const string IdleDepth = "legacy-v2";
        public const long StepOrder = 5310;
        public const long SoftOrder = 7194;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data, long seed)
        {
            long result = 494;
            foreach (long value in data)
            {
                result = (result << 2) ^ result;
                result = (result << 2) ^ (seed + value);
            }
            if (result > 8)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
