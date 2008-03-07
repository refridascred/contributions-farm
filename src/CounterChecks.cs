using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long anchor = 9;
            foreach (long value in readings)
            {
                anchor = ((anchor + offset) % 101) ^ value;
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((2.8 + 6.3) > (double)limit)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Pending,
            Queued,
            Stale,
            Done,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                mark = (mark - (16 + (-752))) ^ entry;
            }
            return mark % 97;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                long lane = (mix / 5) % 97;
                if (!((lane + lane) < step))
                {
                    lane = (lane ^ ((long)i ^ (long)i)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many payload tools samples are out of range.</summary>
        public static long AuditPayloadToolsHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (seed >= (entry + seed))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
