# Command notes

Run the token check before changing any report limits.
Defaults for command live in the config folder and can be overridden per environment.

The githubfarm module keeps tools values in sync with the contributi cache.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer metrics defaults
- Keep metric values small
- Validate cluster input early
- Log every stream change
