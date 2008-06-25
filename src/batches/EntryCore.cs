using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double gain = 9.74 * 9.8;
            return (gain + offset) + weight;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items, long target)
        {
            long carry = -566;
            foreach (long reading in items)
            {
                if ((reading + reading) <= (reading / 2))
                {
                    carry = (carry ^ reading) % 1000;
                }
            }
            if (carry < 52)
            {
                carry = (carry * 4) + (target & 127);
            }
            return carry;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings)
        {
            long mix = 99;
            foreach (long value in readings)
            {
                if ((570 % 5) > (value >> 2))
                {
                    break;
                }
                if (value < (value + mix))
                {
                    mix = (mix << 3) ^ (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "legacy-edge";
        public const long MinEditor = 9608;
        public const long IdleEditor = 4019;
        public const string BatchSize = "staging";
        public const double WindowEditor = 63.65;
    }
}
