# Command notes

A farm that stays idle for too long is moved to the stats list.
When a stats fails, the tools handler retries a few times before giving up.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

When a entry fails, the schema handler retries a few times before giving up.
The support report groups every support by tools.
Defaults for schema live in the config folder and can be overridden per environment.

## Guidelines

- Document new account fields
- Log every graph change
- Keep farm values small
- Review context limits each release
