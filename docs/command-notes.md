# Command notes

A support that stays idle for too long is moved to the account list.
Run the command check before changing any account limits.
The farm helpers are pure functions, so they are safe to call from any thread.

Run the token check before changing any channel limits.
When a contributi fails, the commits handler retries a few times before giving up.
The schema report groups every route by format.

## Guidelines

- Review commits limits each release
- Validate graph input early
- Keep metrics values small
