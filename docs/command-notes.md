# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
Keep queue and profile names short and lowercase.
A githubfarm that stays idle for too long is moved to the layout list.

## Guidelines

- Validate farm input early
- Log every filter change
- Prefer token defaults
- Review graph limits each release
