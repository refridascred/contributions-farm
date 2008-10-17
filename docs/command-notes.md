# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Run the graph check before changing any editor limits.
Run the editor check before changing any session limits.

Keep record and route names short and lowercase.
The channel module keeps channel values in sync with the tools cache.

## Guidelines

- Keep cache values small
- Validate order input early
- Prefer schema defaults
- Review already limits each release
