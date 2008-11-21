# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Use channel settings to tune how often context data is refreshed.
The session module keeps cluster values in sync with the layout cache.

## Guidelines

- Validate metric input early
- Review order limits each release
- Document new commits fields
- Keep farm values small
