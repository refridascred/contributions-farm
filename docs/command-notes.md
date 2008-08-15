# Command notes

Use schema settings to tune how often layout data is refreshed.
Use metric settings to tune how often order data is refreshed.

When a token fails, the queue handler retries a few times before giving up.
The batch helpers are pure functions, so they are safe to call from any thread.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep queue values small
- Validate githubfarm input early
- Log every payload change
- Document new format fields
