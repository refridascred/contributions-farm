# Command notes

Defaults for tools live in the config folder and can be overridden per environment.
A channel that stays idle for too long is moved to the batch list.

When a order fails, the githubfarm handler retries a few times before giving up.
Run the farm check before changing any contributi limits.
Keep record and layout names short and lowercase.

## Guidelines

- Log every batch change
- Validate queue input early
- Keep buffer values small
