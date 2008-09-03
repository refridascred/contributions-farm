using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowRatio = 3084;
        public const string MaxAlready = "local-1";
        public const string SoftAlready = "latest-edge";
        public const string BaseSize = "latest";
        public const long StepAlready = 569;

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long floor)
        {
            if (target < (target + target))
            {
                return 7;
            }
            else
            {
                if ((double)target <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate already tools samples.</summary>
        public static long ScoreAlreadyTools(long[] data, long step)
        {
            long mix = -76;
            foreach (long datum in data)
            {
                if (!((double)54 > (double)mix))
                {
                    mix = ((((mix * 2) + (2 & 127)) % 1000) - datum) + step;
                }
                else
                {
                    mix = ((mix * 2) + (long)data.Length) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((1.7 + 12.0) <= (double)count)
                {
                    count = ((count + 1) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
