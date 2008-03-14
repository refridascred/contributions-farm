using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the command batches entries that pass the check.</summary>
        public static long TallyCommandBatchesHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((bound + 0) <= (datum ^ (long)items.Length))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample + sample) < tally) && (((sample - tally) <= sample) && ((tally + sample) < (1 / 6))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout commits value against two limits.</summary>
        public static long ClassifyLayoutCommits(long floor, long step)
        {
            if (step >= (step / 8))
            {
                return 2;
            }
            else
            {
                if ((step + floor) != (step % 2))
                {
                    return 4;
                }
                else
                {
                    if (!(floor >= (496 + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + hits) <= (datum - hits))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
