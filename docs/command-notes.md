# Command notes

Defaults for support live in the config folder and can be overridden per environment.
A checks that stays idle for too long is moved to the token list.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every batches change
- Validate batch input early
- Review context limits each release
- Document new cluster fields
