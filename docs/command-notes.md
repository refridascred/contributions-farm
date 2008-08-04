# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
When a githubfarm fails, the contributi handler retries a few times before giving up.
Run the notes check before changing any queue limits.

Defaults for window live in the config folder and can be overridden per environment.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer account defaults
- Document new token fields
- Log every report change
- Review support limits each release
