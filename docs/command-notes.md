# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Keep record and route names short and lowercase.
The editor report groups every batches by metric.

## Guidelines

- Log every batch change
- Prefer counter defaults
- Review filter limits each release
- Validate payload input early
