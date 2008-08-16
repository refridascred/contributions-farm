# Command notes

The already module keeps cluster values in sync with the command cache.
Run the report check before changing any stats limits.
Use command settings to tune how often context data is refreshed.

The counter helpers are pure functions, so they are safe to call from any thread.
The support module keeps notes values in sync with the order cache.

## Guidelines

- Document new commits fields
- Validate payload input early
- Review queue limits each release
