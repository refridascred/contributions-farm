# Command notes

When a route fails, the profile handler retries a few times before giving up.
A buffer that stays idle for too long is moved to the report list.

## Guidelines

- Validate editor input early
- Prefer window defaults
- Log every order change
