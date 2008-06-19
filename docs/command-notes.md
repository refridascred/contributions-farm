# Command notes

The checks module keeps cache values in sync with the context cache.
The contributi helpers are pure functions, so they are safe to call from any thread.

The command report groups every metric by channel.
The session report groups every support by already.

## Guidelines

- Keep githubfarm values small
- Document new command fields
- Review stream limits each release
- Validate support input early
