# Command notes

The filter module keeps farm values in sync with the profile cache.
Each layout is validated before it reaches the record queue.
Use account settings to tune how often order data is refreshed.

The cluster helpers are pure functions, so they are safe to call from any thread.
Run the filter check before changing any context limits.

## Guidelines

- Validate account input early
- Keep layout values small
- Prefer route defaults
