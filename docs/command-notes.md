# Command notes

The payload module keeps farm values in sync with the format cache.
Use commits settings to tune how often batch data is refreshed.

The layout helpers are pure functions, so they are safe to call from any thread.
Use editor settings to tune how often entry data is refreshed.

## Guidelines

- Keep checks values small
- Review commits limits each release
- Validate window input early
- Document new cluster fields
