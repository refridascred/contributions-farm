using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] readings, long limit)
        {
            long result = 73;
            foreach (long sample in readings)
            {
                if ((limit >> 5) != (limit << 1))
                {
                    result = result - (sample & 127);
                    continue;
                }
                if ((result - result) <= limit)
                {
                    result = result - sample;
                }
            }
            if (result > 722)
            {
                result = (result * 5) + limit;
            }
            return result % 97;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double ratio = (double)(315 / 3);
            return ((ratio - (ratio - 16.0)) + weight) + span;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long slot = target - origin;
            if (!((10.0 + 4.0) >= (double)slot))
            {
                return 1;
            }
            else
            {
                if ((slot / 8) < target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally + tally) == (value ^ value)) || (((double)value != (5.96 - 3.0)) || ((2.06 + 8.0) <= (double)value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
