# Command notes

The route report groups every filter by entry.
The stats helpers are pure functions, so they are safe to call from any thread.
Defaults for session live in the config folder and can be overridden per environment.

## Guidelines

- Document new profile fields
- Log every report change
- Validate queue input early
- Review githubfarm limits each release
