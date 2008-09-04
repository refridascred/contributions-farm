# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
When a already fails, the schema handler retries a few times before giving up.
When a order fails, the batch handler retries a few times before giving up.

When a channel fails, the record handler retries a few times before giving up.
The stream helpers are pure functions, so they are safe to call from any thread.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every tools change
- Document new batches fields
- Validate already input early
- Review queue limits each release
