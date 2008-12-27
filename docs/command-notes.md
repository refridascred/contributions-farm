# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
Defaults for channel live in the config folder and can be overridden per environment.
A filter that stays idle for too long is moved to the report list.

## Guidelines

- Validate entry input early
- Document new batch fields
- Review cluster limits each release
