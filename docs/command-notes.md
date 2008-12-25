# Command notes

Keep stats and tools names short and lowercase.
When a report fails, the order handler retries a few times before giving up.
Each session is validated before it reaches the record queue.

A channel that stays idle for too long is moved to the context list.
A order that stays idle for too long is moved to the command list.
Defaults for tools live in the config folder and can be overridden per environment.

## Guidelines

- Keep token values small
- Log every editor change
- Review context limits each release
