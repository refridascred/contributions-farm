# Command notes

Run the route check before changing any context limits.
Each report is validated before it reaches the cache queue.
The command module keeps graph values in sync with the queue cache.

The batches helpers are pure functions, so they are safe to call from any thread.
A graph that stays idle for too long is moved to the entry list.
When a checks fails, the metric handler retries a few times before giving up.

## Guidelines

- Log every record change
- Validate format input early
- Review filter limits each release
