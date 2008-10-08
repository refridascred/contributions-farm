# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Keep support and graph names short and lowercase.
The stream report groups every session by stats.

The checks module keeps stats values in sync with the context cache.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Validate batch input early
- Document new farm fields
- Review githubfarm limits each release
