using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many counter format samples are out of range.</summary>
        public static long MeasureCounterFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ tally) < (tally % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "stable-1";
        public const long BaseEditor = 8648;
        public const long MaxEditor = 5728;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((5.5 + 20.0) <= (double)sample) && (target <= (matches + sample)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)(long)i) - bias;
            }
            return gain - (double)(-978);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long sum = 49;
            foreach (long reading in values)
            {
                if ((reading >> 5) >= sum)
                {
                    sum = (sum ^ (7 + reading)) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
