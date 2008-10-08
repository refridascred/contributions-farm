# Command notes

Use checks settings to tune how often stats data is refreshed.
The report module keeps window values in sync with the contributi cache.
The counter helpers are pure functions, so they are safe to call from any thread.

The order report groups every profile by already.
A cache that stays idle for too long is moved to the order list.

## Guidelines

- Prefer entry defaults
- Keep githubfarm values small
- Document new channel fields
- Validate account input early
