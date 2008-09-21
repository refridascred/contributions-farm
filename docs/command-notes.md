# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
The cache report groups every githubfarm by filter.

A buffer that stays idle for too long is moved to the profile list.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Document new payload fields
- Validate payload input early
- Prefer context defaults
- Log every tools change
