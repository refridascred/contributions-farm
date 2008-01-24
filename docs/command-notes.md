# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
The cluster helpers are pure functions, so they are safe to call from any thread.
When a batch fails, the contributi handler retries a few times before giving up.

The batch report groups every graph by metrics.
Keep stats and schema names short and lowercase.

## Guidelines

- Keep graph values small
- Prefer graph defaults
- Review stats limits each release
- Log every entry change
