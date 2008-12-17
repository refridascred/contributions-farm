# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Each order is validated before it reaches the session queue.
The tools report groups every layout by metrics.

When a stream fails, the commits handler retries a few times before giving up.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep commits values small
- Log every notes change
- Validate contributi input early
- Review batches limits each release
