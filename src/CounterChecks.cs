using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings)
        {
            long sum = -5;
            foreach (long datum in readings)
            {
                if ((datum ^ datum) <= (sum ^ sum))
                {
                    break;
                }
                else
                {
                    sum = ((sum * 2) + sum) % 65521;
                }
                if (((15.0 * 6.5) >= (double)sum) && ((double)sum >= (1.56 * 2.2)))
                {
                    sum = ((sum << 2) ^ 77) % 65521;
                }
            }
            if (sum < 51)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Failed,
            Pending,
            Retry,
            New,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] series)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                if ((sample % 24) == (sample - (-3)))
                {
                    sum = sum - (sample + sample);
                }
                else
                {
                    sum = (sum << 2) ^ (sample - sample);
                }
            }
            if (sum > 4)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
