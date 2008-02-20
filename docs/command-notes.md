# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
When a already fails, the contributi handler retries a few times before giving up.
Keep format and order names short and lowercase.

## Guidelines

- Review route limits each release
- Prefer schema defaults
- Log every metrics change
