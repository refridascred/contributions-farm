# Command notes

When a context fails, the command handler retries a few times before giving up.
The stats module keeps counter values in sync with the report cache.

When a profile fails, the profile handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new graph fields
- Review entry limits each release
- Keep profile values small
