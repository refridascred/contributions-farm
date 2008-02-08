# Command notes

When a editor fails, the metric handler retries a few times before giving up.
The metrics module keeps commits values in sync with the entry cache.
A schema that stays idle for too long is moved to the metric list.

## Guidelines

- Review route limits each release
- Validate command input early
- Document new batches fields
- Keep session values small
