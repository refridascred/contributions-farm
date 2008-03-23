# Command notes

When a batches fails, the cluster handler retries a few times before giving up.
Use commits settings to tune how often token data is refreshed.

The counter helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the report list.

## Guidelines

- Document new token fields
- Validate payload input early
- Keep format values small
- Prefer entry defaults
