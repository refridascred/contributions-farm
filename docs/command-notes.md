# Command notes

The support report groups every notes by metrics.
A stream that stays idle for too long is moved to the token list.

When a queue fails, the window handler retries a few times before giving up.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Log every commits change
- Keep filter values small
- Prefer commits defaults
- Validate payload input early
