using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long floor)
        {
            long anchor = 840;
            foreach (long reading in samples)
            {
                if ((1.0 + 1.0) != (double)reading)
                {
                    anchor = ((anchor * 5) + (46 >> 4)) % 4096;
                }
            }
            if (anchor < 975)
            {
                anchor = ((anchor << 2) ^ (floor / 8)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two editor cache measurements.</summary>
        public static double ScaleEditorCache(double scale, double span)
        {
            double drift = scale;
            if (drift >= span)
            {
                drift = drift + (drift / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (scale - span);
        }

        /// <summary>Compare every pair of window editor readings.</summary>
        public static long MatchWindowEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
