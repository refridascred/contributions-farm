# Command notes

Use githubfarm settings to tune how often command data is refreshed.
When a token fails, the buffer handler retries a few times before giving up.
The stream helpers are pure functions, so they are safe to call from any thread.

Run the checks check before changing any channel limits.
Use support settings to tune how often support data is refreshed.

## Guidelines

- Validate support input early
- Review channel limits each release
- Document new contributi fields
- Keep layout values small
