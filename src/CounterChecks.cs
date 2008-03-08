using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels, long origin)
        {
            long acc = -163;
            foreach (long item in levels)
            {
                if ((acc & 63) < (origin - origin))
                {
                    acc = ((acc << 3) ^ (acc - (long)levels.Length)) + item;
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long origin)
        {
            if (562 >= (origin + bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (17.0 + 7.2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long offset)
        {
            long state = 8;
            foreach (long datum in data)
            {
                if ((double)state >= (10.0 * 2.97))
                {
                    state = state - offset;
                    state = (state * 3) + (datum << 1);
                }
                if (((-4) << 2) == (state << 2))
                {
                    state = ((state * 3) + (offset * 3)) % 101;
                }
            }
            if (state > 3)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long step)
        {
            long acc = 170;
            foreach (long reading in series)
            {
                if ((reading - reading) > reading)
                {
                    acc = (acc ^ (step << 1)) % 4096;
                }
                else
                {
                    acc = acc + (reading & 31);
                }
            }
            if (acc < 773)
            {
                acc = (acc * 2) + (step ^ acc);
            }
            return acc;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings, long step)
        {
            long carry = 937;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ reading) % 65521;
                carry = (carry - (step ^ carry)) % 65521;
            }
            if (carry < 794)
            {
                carry = ((carry << 3) ^ (step + step)) % 1000;
            }
            return carry;
        }
    }
}
