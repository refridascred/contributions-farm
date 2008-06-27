# Command notes

Each schema is validated before it reaches the channel queue.
Defaults for context live in the config folder and can be overridden per environment.
A window that stays idle for too long is moved to the batch list.

A format that stays idle for too long is moved to the route list.
Defaults for token live in the config folder and can be overridden per environment.
The batch module keeps account values in sync with the editor cache.

## Guidelines

- Keep counter values small
- Log every account change
- Review tools limits each release
