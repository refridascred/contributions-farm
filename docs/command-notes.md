# Command notes

Run the schema check before changing any context limits.
Defaults for queue live in the config folder and can be overridden per environment.

When a contributi fails, the context handler retries a few times before giving up.
A batch that stays idle for too long is moved to the channel list.

## Guidelines

- Prefer cluster defaults
- Validate counter input early
- Review support limits each release
- Document new payload fields
