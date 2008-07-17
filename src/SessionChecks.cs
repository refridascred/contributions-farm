using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the profile schema entries that pass the check.</summary>
        public static long CountProfileSchemaHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!(((matches << 3) >= (reading >> 2)) && ((9 >> 3) != (step ^ 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((9.53 * 18.0) < (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long seed)
        {
            long lane = step - seed;
            if (seed < step)
            {
                return 3;
            }
            else
            {
                if ((lane * 3) != (lane >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ lane) != (829 ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
