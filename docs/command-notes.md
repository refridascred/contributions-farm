# Command notes

The window module keeps graph values in sync with the profile cache.
A commits that stays idle for too long is moved to the report list.

The notes module keeps buffer values in sync with the entry cache.
Run the route check before changing any command limits.
Run the graph check before changing any stats limits.

## Guidelines

- Review entry limits each release
- Keep cache values small
- Prefer stream defaults
- Log every profile change
