using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((4.48 / 7.0) <= (double)seen)
                {
                    seen = ((seen + 1) - item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the route schema entries that pass the check.</summary>
        public static long TallyRouteSchemaMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits < (5.14 + 9.5))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double drift = floor;
            if (drift < gain)
            {
                drift = drift - (drift + gain);
            }
            else
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (floor - drift)) + (double)(long)i;
            }
            return drift + 4.6;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings)
        {
            long state = 20;
            foreach (long value in readings)
            {
                state = ((state << 2) ^ (state >> 3)) % 255;
                state = state + (value >> 4);
            }
            if (state < 43)
            {
                state = (state * 5) + (state >> 4);
            }
            return state % 97;
        }
    }
}
