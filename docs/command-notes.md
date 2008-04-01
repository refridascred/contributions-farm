# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
The commits module keeps context values in sync with the already cache.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Validate entry input early
- Document new farm fields
- Prefer farm defaults
- Keep githubfarm values small
