# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Keep stream values small
- Prefer buffer defaults
- Log every record change
- Document new githubfarm fields
