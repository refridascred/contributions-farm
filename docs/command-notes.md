# Command notes

Run the tools check before changing any checks limits.
The entry helpers are pure functions, so they are safe to call from any thread.
When a already fails, the stream handler retries a few times before giving up.

Use counter settings to tune how often entry data is refreshed.
The format report groups every order by context.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer channel defaults
- Keep record values small
- Log every already change
- Document new channel fields
