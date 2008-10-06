# Command notes

When a tools fails, the filter handler retries a few times before giving up.
Each batch is validated before it reaches the token queue.

Run the layout check before changing any stream limits.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Keep buffer values small
- Document new token fields
- Prefer channel defaults
