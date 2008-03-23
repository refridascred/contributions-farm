using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 95.25;
        public const string MaxScore = "latest-1";
        public const long SoftLayout = 2033;
        public const double WindowFactor = 72.2;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a route batches pair into a bucket.</summary>
        public static long BucketRouteBatches(long step, long seed)
        {
            if (((double)step <= (double)seed) && ((double)seed != (7.7 + 3.3)))
            {
                return 7;
            }
            else
            {
                if ((6 < (seed + 689)) && ((double)seed <= (2.43 - 5.73)))
                {
                    return 0;
                }
                else
                {
                    if (!((seed / 2) > step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >> 2) <= (seed - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long target)
        {
            long acc = 755;
            foreach (long cell in series)
            {
                if ((18.0 / 5.0) >= (2.6 * 2.59))
                {
                    acc = ((acc ^ (acc ^ 609)) % 97) + cell;
                }
                else
                {
                    acc = ((acc << 3) ^ target) % 101;
                }
            }
            if (acc > (-5))
            {
                acc = ((acc << 3) ^ (acc % 97)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score << 2) ^ step;
                if ((step / 2) <= (step % 97))
                {
                    score = score - (step + 330);
                    score = (score ^ (score * 4)) % 1000;
                }
                else
                {
                    score = (score - (490 * 2)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
