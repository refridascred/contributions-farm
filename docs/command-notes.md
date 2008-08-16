# Command notes

A cluster that stays idle for too long is moved to the command list.
The counter module keeps context values in sync with the layout cache.
A format that stays idle for too long is moved to the buffer list.

## Guidelines

- Prefer stream defaults
- Validate filter input early
- Keep cache values small
- Review batch limits each release
