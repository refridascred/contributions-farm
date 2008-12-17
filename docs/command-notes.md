# Command notes

A layout that stays idle for too long is moved to the batch list.
A buffer that stays idle for too long is moved to the graph list.
Run the account check before changing any schema limits.

Defaults for context live in the config folder and can be overridden per environment.
The counter module keeps checks values in sync with the stats cache.

## Guidelines

- Review session limits each release
- Keep support values small
- Log every cache change
- Prefer order defaults
