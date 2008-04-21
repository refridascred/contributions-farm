# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Run the payload check before changing any cache limits.
Each account is validated before it reaches the cache queue.

Use channel settings to tune how often schema data is refreshed.
Use batches settings to tune how often profile data is refreshed.

## Guidelines

- Prefer route defaults
- Review layout limits each release
- Log every route change
