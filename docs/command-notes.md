# Command notes

A channel that stays idle for too long is moved to the stream list.
Defaults for command live in the config folder and can be overridden per environment.

Run the schema check before changing any buffer limits.
Each payload is validated before it reaches the account queue.

## Guidelines

- Document new session fields
- Prefer channel defaults
- Review commits limits each release
