# Layout notes

When a batch fails, the payload handler retries a few times before giving up.
The payload report groups every session by cache.
Run the channel check before changing any format limits.

The cluster report groups every stream by token.
Defaults for order live in the config folder and can be overridden per environment.

## Guidelines

- Validate cache input early
- Review farm limits each release
- Log every checks change
