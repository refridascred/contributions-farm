# Command notes

Run the editor check before changing any editor limits.
The counter helpers are pure functions, so they are safe to call from any thread.

Use graph settings to tune how often metrics data is refreshed.
A route that stays idle for too long is moved to the cache list.

## Guidelines

- Review batch limits each release
- Prefer cache defaults
- Validate account input early
