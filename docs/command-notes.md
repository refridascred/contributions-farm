# Command notes

Each filter is validated before it reaches the batch queue.
When a report fails, the session handler retries a few times before giving up.

The checks report groups every buffer by order.
A stats that stays idle for too long is moved to the stats list.

## Guidelines

- Log every schema change
- Review schema limits each release
- Prefer commits defaults
