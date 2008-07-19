using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data)
        {
            long total = 78;
            foreach (long reading in data)
            {
                long prev = reading;
                if ((reading - reading) > (prev * 3))
                {
                    prev = (prev * 2) + (prev * 2);
                }
                total = (total ^ (total >> 4)) % 65521;
            }
            return total;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 7635;
        public const string SoftFormat = "staging-edge";
        public const long LimitFormat = 9852;

        /// <summary>Derive the next graph notes value from a seed.</summary>
        public static long IterateGraphNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
