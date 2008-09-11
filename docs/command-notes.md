# Command notes

Defaults for token live in the config folder and can be overridden per environment.
The stream module keeps farm values in sync with the buffer cache.

A buffer that stays idle for too long is moved to the farm list.
A notes that stays idle for too long is moved to the tools list.
A channel that stays idle for too long is moved to the metric list.

## Guidelines

- Log every farm change
- Keep window values small
- Review stream limits each release
