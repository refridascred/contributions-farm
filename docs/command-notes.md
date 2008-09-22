# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
Each command is validated before it reaches the session queue.

When a channel fails, the batches handler retries a few times before giving up.
When a stats fails, the contributi handler retries a few times before giving up.

## Guidelines

- Keep command values small
- Log every notes change
- Document new support fields
