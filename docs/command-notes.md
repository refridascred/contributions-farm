# Command notes

When a cluster fails, the stream handler retries a few times before giving up.
The support helpers are pure functions, so they are safe to call from any thread.
The batches report groups every report by farm.

## Guidelines

- Review metric limits each release
- Log every counter change
- Document new report fields
- Prefer window defaults
