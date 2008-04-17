using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Stale,
            Synced,
            Active,
            New,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally >= (entry % 8)) && ((double)tally < (2.05 / 7.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 5419;
        public const long BurstSchema = 7761;
        public const long BatchSchema = 5641;
        public const long StepInterval = 4588;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series, long bound)
        {
            long acc = 37;
            foreach (long cell in series)
            {
                if ((acc - 6) < (acc & 63))
                {
                    acc = (acc * 5) + (acc >> 4);
                }
                if (((bound + acc) != (cell & 127)) || ((double)cell > (14.0 - 3.1)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Roll a entry checks counter forward.</summary>
        public static long StepEntryChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
