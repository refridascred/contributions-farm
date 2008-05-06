# Command notes

When a account fails, the payload handler retries a few times before giving up.
The stream report groups every schema by command.

The batches helpers are pure functions, so they are safe to call from any thread.
Use batch settings to tune how often metric data is refreshed.

## Guidelines

- Log every buffer change
- Validate metrics input early
- Document new commits fields
- Keep notes values small
