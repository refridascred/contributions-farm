# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Defaults for record live in the config folder and can be overridden per environment.
Keep githubfarm and cache names short and lowercase.

A entry that stays idle for too long is moved to the profile list.
The commits report groups every editor by format.

## Guidelines

- Review payload limits each release
- Prefer graph defaults
- Validate editor input early
