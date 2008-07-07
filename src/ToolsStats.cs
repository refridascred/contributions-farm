using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "stable-edge";
        public const long BatchSpan = 9779;
        public const long WindowCluster = 4566;

        /// <summary>Find the first notes batch entry that matches the target.</summary>
        public static long LookupNotesBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings, long floor)
        {
            long mix = -81;
            foreach (long datum in readings)
            {
                if ((double)datum != (double)6)
                {
                    mix = ((mix - (-9)) % 97) + floor;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long TallyCommitsWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally >= (tally - reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long target2)
        {
            if ((target + target) >= 1)
            {
                return 8;
            }
            else
            {
                if (((-878) * 5) > (target - target2))
                {
                    return 0;
                }
                else
                {
                    if ((13.0 / 2.0) <= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
