# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
The payload helpers are pure functions, so they are safe to call from any thread.
The tools report groups every notes by cluster.

## Guidelines

- Log every queue change
- Validate metric input early
- Keep commits values small
- Document new commits fields
