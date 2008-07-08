# Command notes

A entry that stays idle for too long is moved to the stats list.
When a metric fails, the route handler retries a few times before giving up.

## Guidelines

- Document new metric fields
- Validate schema input early
- Keep queue values small
- Log every batches change
