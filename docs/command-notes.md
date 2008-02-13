# Command notes

Keep cache and order names short and lowercase.
The checks module keeps batches values in sync with the layout cache.
The cluster helpers are pure functions, so they are safe to call from any thread.

The stats helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often record data is refreshed.

## Guidelines

- Validate counter input early
- Review entry limits each release
- Prefer context defaults
- Log every contributi change
