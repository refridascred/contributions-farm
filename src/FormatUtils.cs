using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                if ((82 - 7) > carry)
                {
                    carry = (((carry * 5) + (carry - 40)) % 101) - reading;
                }
            }
            return carry % 65521;
        }

        /// <summary>Iterate the notes tools series from a seed.</summary>
        public static long StepNotesTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                long span = (result - (long)i) - ((long)i / 5);
                double mean = (double)span + (double)span;
                if (!(((result + floor) < ((long)i + floor)) || ((double)span <= (mean / 7.0))))
                {
                    span = ((span << 2) ^ (floor >> 1)) % 101;
                    mean = mean - (mean - mean);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (409 + datum))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset <= step) && ((14.0 * 4.3) <= (double)offset))
            {
                return 1;
            }
            else
            {
                if (!((next * 4) > (8 + next)))
                {
                    return 2;
                }
                else
                {
                    if (((offset * 3) < (offset % 10)) && ((next ^ step) < (next + 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
