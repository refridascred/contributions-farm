# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the cluster handler retries a few times before giving up.
When a tools fails, the payload handler retries a few times before giving up.

## Guidelines

- Keep window values small
- Validate channel input early
- Document new stream fields
- Log every queue change
