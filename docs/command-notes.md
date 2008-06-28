# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
Keep queue and channel names short and lowercase.

Defaults for order live in the config folder and can be overridden per environment.
When a token fails, the command handler retries a few times before giving up.
Run the batches check before changing any queue limits.

## Guidelines

- Log every stats change
- Document new support fields
- Review context limits each release
