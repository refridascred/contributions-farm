# Command notes

Run the command check before changing any editor limits.
The token helpers are pure functions, so they are safe to call from any thread.
Run the session check before changing any githubfarm limits.

Keep order and session names short and lowercase.
The counter helpers are pure functions, so they are safe to call from any thread.
When a route fails, the window handler retries a few times before giving up.

## Guidelines

- Review channel limits each release
- Validate order input early
- Document new payload fields
