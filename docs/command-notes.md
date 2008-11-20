# Command notes

Run the profile check before changing any buffer limits.
A tools that stays idle for too long is moved to the queue list.
A schema that stays idle for too long is moved to the account list.

When a channel fails, the payload handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep order values small
- Document new contributi fields
- Review profile limits each release
