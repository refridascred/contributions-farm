# Command notes

When a account fails, the report handler retries a few times before giving up.
Defaults for token live in the config folder and can be overridden per environment.
Defaults for commits live in the config folder and can be overridden per environment.

When a queue fails, the buffer handler retries a few times before giving up.
A window that stays idle for too long is moved to the record list.
Run the token check before changing any token limits.

## Guidelines

- Document new record fields
- Keep cluster values small
- Log every checks change
