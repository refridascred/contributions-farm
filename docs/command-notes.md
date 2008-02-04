# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Keep route and session names short and lowercase.

Use channel settings to tune how often farm data is refreshed.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Validate record input early
- Document new farm fields
- Keep already values small
