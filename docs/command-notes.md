# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Run the entry check before changing any farm limits.
The tools module keeps context values in sync with the cluster cache.

Run the notes check before changing any layout limits.
A route that stays idle for too long is moved to the token list.

## Guidelines

- Document new format fields
- Prefer commits defaults
- Validate farm input early
