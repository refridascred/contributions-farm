# Command notes

The graph module keeps stats values in sync with the cache cache.
Run the account check before changing any batches limits.
The farm module keeps stream values in sync with the notes cache.

A cache that stays idle for too long is moved to the stats list.
When a metric fails, the window handler retries a few times before giving up.
A farm that stays idle for too long is moved to the payload list.

## Guidelines

- Document new context fields
- Prefer checks defaults
- Log every report change
