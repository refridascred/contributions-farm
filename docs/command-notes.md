# Command notes

When a batch fails, the stream handler retries a few times before giving up.
Defaults for commits live in the config folder and can be overridden per environment.
Keep window and notes names short and lowercase.

When a profile fails, the token handler retries a few times before giving up.
A metrics that stays idle for too long is moved to the stream list.

## Guidelines

- Prefer context defaults
- Validate entry input early
- Keep command values small
- Document new batches fields
