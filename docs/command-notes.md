# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Run the cache check before changing any support limits.
The tools module keeps order values in sync with the counter cache.

## Guidelines

- Document new token fields
- Validate filter input early
- Review buffer limits each release
