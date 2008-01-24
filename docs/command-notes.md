# Command notes

Each session is validated before it reaches the stream queue.
Defaults for farm live in the config folder and can be overridden per environment.
Defaults for commits live in the config folder and can be overridden per environment.

The layout report groups every already by channel.
A tools that stays idle for too long is moved to the context list.

## Guidelines

- Validate batches input early
- Keep metrics values small
- Review metrics limits each release
