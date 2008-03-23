# Command notes

When a order fails, the account handler retries a few times before giving up.
Each stats is validated before it reaches the entry queue.
A order that stays idle for too long is moved to the report list.

## Guidelines

- Validate commits input early
- Prefer queue defaults
- Keep commits values small
- Review order limits each release
