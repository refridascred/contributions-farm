# Command notes

Run the tools check before changing any order limits.
The metrics module keeps counter values in sync with the token cache.
A token that stays idle for too long is moved to the command list.

## Guidelines

- Prefer token defaults
- Validate account input early
- Review cluster limits each release
- Keep cache values small
