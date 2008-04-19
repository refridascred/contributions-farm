# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
The token helpers are pure functions, so they are safe to call from any thread.
Use context settings to tune how often metric data is refreshed.

Run the batch check before changing any profile limits.
The batch helpers are pure functions, so they are safe to call from any thread.
When a order fails, the profile handler retries a few times before giving up.

## Guidelines

- Document new schema fields
- Keep record values small
- Log every metric change
- Validate counter input early
