# Command notes

Use notes settings to tune how often route data is refreshed.
Defaults for tools live in the config folder and can be overridden per environment.
A queue that stays idle for too long is moved to the channel list.

Each already is validated before it reaches the context queue.
Each schema is validated before it reaches the checks queue.

## Guidelines

- Keep farm values small
- Validate order input early
- Document new format fields
- Review counter limits each release
