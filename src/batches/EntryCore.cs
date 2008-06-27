using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two notes contributi measurements.</summary>
        public static double AdjustNotesContributi(double gain, double bias)
        {
            double weight = bias + (double)620;
            return (weight - 19.0) + gain;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long offset)
        {
            if (((origin % 60) <= (offset - offset)) || ((double)origin >= (double)offset))
            {
                return 3;
            }
            else
            {
                if ((offset * 3) > (-806))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Adjust a support farm reading.</summary>
        public static double BlendSupportFarm(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (double)4) + (double)(long)i) + rate;
            }
            return ratio - ratio;
        }
    }
}
