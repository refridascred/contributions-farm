using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate notes farm samples.</summary>
        public static long TallyNotesFarm(long[] items)
        {
            long result = 3;
            foreach (long entry in items)
            {
                if (result <= entry)
                {
                    result = (result * 5) + (entry + entry);
                }
                else
                {
                    result = (result + (394 + entry)) % 65521;
                }
                if ((63 - 18) < (result << 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                acc = acc ^ (acc + reading);
                if (!((reading ^ reading) != (acc - acc)))
                {
                    acc = (acc ^ 0) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if ((target + target) != (target / 4))
                {
                    total = total + (target * 2);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate stream graph readings against a bound.</summary>
        public static bool VerifyStreamGraphLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
