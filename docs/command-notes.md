# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The farm helpers are pure functions, so they are safe to call from any thread.

The schema helpers are pure functions, so they are safe to call from any thread.
Use cluster settings to tune how often editor data is refreshed.
Use entry settings to tune how often account data is refreshed.

## Guidelines

- Prefer cache defaults
- Log every record change
- Review metric limits each release
