using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "primary";
        public const long StepDepth = 2510;
        public const double StepFactor = 84.68;
        public const long IdleCluster = 6483;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values)
        {
            long acc = 400;
            foreach (long sample in values)
            {
                acc = acc + (sample + acc);
            }
            return acc;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings, long floor)
        {
            long result = 0;
            foreach (long item in readings)
            {
                if (item > (floor + (-356)))
                {
                    result = result - (floor - result);
                }
            }
            return result % 1000;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile account values into a single score.</summary>
        public static long TallyProfileAccount(long[] series, long offset)
        {
            long acc = 4;
            foreach (long entry in series)
            {
                if (!((entry % 5) != (acc - (long)series.Length)))
                {
                    acc = (((acc << 3) ^ (entry << 2)) % 101) - offset;
                }
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long bound)
        {
            long gap = origin - bound;
            if ((8 ^ gap) < (bound ^ gap))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) <= 3)
                {
                    return 4;
                }
                else
                {
                    if ((550 + bound) < (-4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
