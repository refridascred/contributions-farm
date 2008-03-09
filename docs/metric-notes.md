# Metric notes

When a support fails, the tools handler retries a few times before giving up.
Each commits is validated before it reaches the cache queue.
When a buffer fails, the context handler retries a few times before giving up.

A counter that stays idle for too long is moved to the channel list.
The order report groups every farm by metric.
Keep metrics and batches names short and lowercase.

## Guidelines

- Keep record values small
- Log every window change
- Validate tools input early
- Review queue limits each release
