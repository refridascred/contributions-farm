# Command notes

Run the counter check before changing any queue limits.
Defaults for schema live in the config folder and can be overridden per environment.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer order defaults
- Document new githubfarm fields
- Validate stream input early
