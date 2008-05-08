# Command notes

The contributi report groups every counter by stream.
Each order is validated before it reaches the filter queue.
Use already settings to tune how often account data is refreshed.

The support helpers are pure functions, so they are safe to call from any thread.
When a buffer fails, the token handler retries a few times before giving up.

## Guidelines

- Document new filter fields
- Prefer record defaults
- Validate layout input early
