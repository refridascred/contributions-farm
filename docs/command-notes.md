# Command notes

The batch module keeps notes values in sync with the route cache.
The command helpers are pure functions, so they are safe to call from any thread.
Use payload settings to tune how often record data is refreshed.

## Guidelines

- Document new layout fields
- Keep session values small
- Review report limits each release
