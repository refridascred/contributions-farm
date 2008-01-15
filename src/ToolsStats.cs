using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next checks editor value.</summary>
        public static double BlendChecksEditor(double scale, double floor)
        {
            double ratio = scale - floor;
            if (ratio >= (floor - floor))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (floor * 13.0);
            }
            return ratio - (ratio * 4.2);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (1.1 >= (double)tally)
                {
                    tally = ((tally + 1) ^ datum) + step;
                }
            }
            return tally;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] series)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                sum = ((sum << 3) ^ 646) + reading;
            }
            return sum;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Locked,
            Queued,
            Stale,
        }
    }
}
