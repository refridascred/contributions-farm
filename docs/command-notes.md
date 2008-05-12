# Command notes

Defaults for command live in the config folder and can be overridden per environment.
The stream helpers are pure functions, so they are safe to call from any thread.
Keep entry and stream names short and lowercase.

## Guidelines

- Document new checks fields
- Prefer cache defaults
- Keep metric values small
- Validate record input early
