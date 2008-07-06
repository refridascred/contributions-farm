# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
The support module keeps payload values in sync with the already cache.
Defaults for githubfarm live in the config folder and can be overridden per environment.

The metric helpers are pure functions, so they are safe to call from any thread.
The cache module keeps report values in sync with the buffer cache.
Keep format and metrics names short and lowercase.

## Guidelines

- Keep format values small
- Review graph limits each release
- Document new route fields
- Validate counter input early
