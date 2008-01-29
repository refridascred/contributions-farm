using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Synced,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of notes queue entries.</summary>
        public static long WeighNotesQueue(long[] levels, long floor)
        {
            long score = 500;
            foreach (long entry in levels)
            {
                if (score <= (floor ^ 77))
                {
                    score = (score * 3) + (floor - entry);
                }
            }
            if (score < 11)
            {
                score = score + (floor + floor);
            }
            return score;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate layout support readings against a bound.</summary>
        public static bool ValidateLayoutSupportLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                if ((mix % 3) < (item ^ 26))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 101;
                }
                else
                {
                    mix = mix + mix;
                    mix = mix - (mix + 6);
                }
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (mix - mix)) % 65521) ^ (long)i;
                }
                mix = ((mix * 3) + mix) % 97;
            }
            return mix;
        }
    }
}
