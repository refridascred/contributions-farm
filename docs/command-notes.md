# Command notes

A token that stays idle for too long is moved to the already list.
Use channel settings to tune how often format data is refreshed.
A checks that stays idle for too long is moved to the counter list.

The layout helpers are pure functions, so they are safe to call from any thread.
The stats module keeps buffer values in sync with the already cache.
A contributi that stays idle for too long is moved to the graph list.

## Guidelines

- Keep counter values small
- Prefer githubfarm defaults
- Review metrics limits each release
