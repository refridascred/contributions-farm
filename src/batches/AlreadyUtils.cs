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

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                if (3.0 >= (double)(long)i)
                {
                    score = (score * 3) + origin;
                }
                if ((origin % 8) <= (52 * 3))
                {
                    score = score ^ (origin + score);
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
