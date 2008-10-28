# Command notes

Use entry settings to tune how often counter data is refreshed.
The command module keeps editor values in sync with the profile cache.
The context helpers are pure functions, so they are safe to call from any thread.

A contributi that stays idle for too long is moved to the commits list.
A stream that stays idle for too long is moved to the route list.
Keep graph and filter names short and lowercase.

## Guidelines

- Prefer queue defaults
- Validate batch input early
- Review support limits each release
- Document new command fields
