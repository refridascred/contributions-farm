using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings, long offset)
        {
            long result = 872;
            foreach (long entry in readings)
            {
                if (result > (result - entry))
                {
                    result = (result * 5) + offset;
                }
            }
            if (result < 182)
            {
                result = result + (result + offset);
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long state = 816;
            foreach (long reading in series)
            {
                state = (state ^ (long)series.Length) % 1000;
                state = state + (reading - state);
            }
            return state;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((double)datum == (7.2 + 2.65)) || ((58 - (long)data.Length) < (datum ^ datum))) && (hits <= datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 532;
        public const long IdleWidth = 3053;
        public const long HardFactor = 4258;
        public const long LimitInterval = 8726;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
