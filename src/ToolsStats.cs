using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long score = 7;
            foreach (long sample in items)
            {
                score = score ^ (sample ^ sample);
                if ((double)sample == (4.06 * 14.0))
                {
                    score = ((score * 3) + (15 & 7)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (8 + score)) % 4096;
                }
            }
            if (score > 342)
            {
                score = (score * 2) + score;
            }
            return score % 4096;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)(-8) > (double)target)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long target)
        {
            long prev = offset + target;
            if ((target >> 2) > prev)
            {
                return 0;
            }
            else
            {
                if (prev <= (prev % 7))
                {
                    return 4;
                }
                else
                {
                    if (((double)prev >= (0.5 - 7.56)) && (offset >= (target + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a queue contributi value against two limits.</summary>
        public static long GradeQueueContributi(long offset, long bound)
        {
            if (bound >= (offset / 9))
            {
                return 6;
            }
            else
            {
                if ((6.33 * 18.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 5) >= (offset >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound ^ offset) < (bound + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
