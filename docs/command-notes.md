# Command notes

Run the buffer check before changing any githubfarm limits.
Run the notes check before changing any token limits.
Keep stream and payload names short and lowercase.

Defaults for record live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer command defaults
- Document new route fields
- Review account limits each release
- Validate payload input early
