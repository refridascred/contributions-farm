# Command notes

Run the schema check before changing any tools limits.
Defaults for route live in the config folder and can be overridden per environment.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review graph limits each release
- Log every tools change
- Keep profile values small
