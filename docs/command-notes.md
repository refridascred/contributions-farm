# Command notes

The channel module keeps queue values in sync with the order cache.
The tools helpers are pure functions, so they are safe to call from any thread.
Use command settings to tune how often farm data is refreshed.

## Guidelines

- Validate stats input early
- Document new stats fields
- Review buffer limits each release
