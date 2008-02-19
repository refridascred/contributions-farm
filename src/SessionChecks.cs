using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long seed)
        {
            if (!((double)offset > (double)seed))
            {
                return 3;
            }
            else
            {
                if (offset <= (offset % 5))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 3) < (offset ^ offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed - 976) == (2 / 7)) || ((seed + offset) >= ((-6) ^ seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((7.5 + 1.5) >= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] items, long origin)
        {
            long anchor = 255;
            foreach (long datum in items)
            {
                anchor = (anchor + origin) % 4096;
                if ((69 * 5) > datum)
                {
                    anchor = anchor ^ (datum * 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Pending,
            Synced,
            New,
            Done,
        }
    }
}
