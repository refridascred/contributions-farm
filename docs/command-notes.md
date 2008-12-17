# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Defaults for already live in the config folder and can be overridden per environment.

A filter that stays idle for too long is moved to the report list.
The buffer module keeps report values in sync with the cluster cache.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer counter defaults
- Document new cache fields
- Validate command input early
- Review tools limits each release
