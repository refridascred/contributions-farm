# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The already module keeps batch values in sync with the contributi cache.
Use githubfarm settings to tune how often tools data is refreshed.

## Guidelines

- Validate session input early
- Document new tools fields
- Prefer record defaults
- Review layout limits each release
