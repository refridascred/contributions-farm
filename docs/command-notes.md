# Command notes

Use batches settings to tune how often tools data is refreshed.
When a batch fails, the account handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stream input early
- Prefer stream defaults
- Keep payload values small
