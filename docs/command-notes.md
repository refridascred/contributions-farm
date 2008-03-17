# Command notes

The schema module keeps counter values in sync with the cache cache.
When a farm fails, the route handler retries a few times before giving up.

The account report groups every batches by metrics.
A notes that stays idle for too long is moved to the session list.

## Guidelines

- Validate stats input early
- Document new notes fields
- Keep route values small
- Log every context change
