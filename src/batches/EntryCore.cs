using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double rate = weight + weight;
            if (rate > rate)
            {
                rate = (rate - 3.96) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (weight - rate)) - (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)seed < 3.93)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] values)
        {
            long mix = 64;
            foreach (long cell in values)
            {
                mix = (mix * 3) + (mix - 18);
                if ((616 + 0) > cell)
                {
                    break;
                }
            }
            if (mix > (-52))
            {
                mix = ((mix * 3) + mix) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Idle,
            Synced,
        }
    }
}
