# Command notes

The account report groups every payload by payload.
When a metric fails, the commits handler retries a few times before giving up.
A entry that stays idle for too long is moved to the token list.

Run the queue check before changing any checks limits.
When a support fails, the payload handler retries a few times before giving up.

## Guidelines

- Prefer support defaults
- Validate metric input early
- Keep batches values small
- Review payload limits each release
