using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i < total) && ((floor * 5) != (total & 31)))
                {
                    total = (total + (total + total)) % 101;
                    total = (total * 2) + (long)i;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double span)
        {
            double ratio = (span * 2.6) / 7.0;
            if (ratio > (7.02 + weight))
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (weight + weight);
        }

        /// <summary>Combine stream token values into a single score.</summary>
        public static long DigestStreamToken(long[] data, long step)
        {
            long sum = 6;
            foreach (long sample in data)
            {
                if ((sample + step) <= (sum - sample))
                {
                    sum = sum ^ (sum ^ step);
                    sum = sum ^ (5 - (-6));
                }
                else
                {
                    sum = (sum ^ (step + step)) % 101;
                }
                sum = (sum - (8 << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
