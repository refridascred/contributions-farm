# Command notes

The githubfarm report groups every context by tools.
Each channel is validated before it reaches the buffer queue.

A checks that stays idle for too long is moved to the cache list.
Run the report check before changing any report limits.

## Guidelines

- Prefer batch defaults
- Document new channel fields
- Keep window values small
- Review window limits each release
