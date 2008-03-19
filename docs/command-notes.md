# Command notes

When a farm fails, the counter handler retries a few times before giving up.
The batches module keeps payload values in sync with the contributi cache.

Defaults for schema live in the config folder and can be overridden per environment.
Each format is validated before it reaches the tools queue.

## Guidelines

- Document new window fields
- Validate window input early
- Log every editor change
- Prefer metrics defaults
