# Command notes

The already module keeps metric values in sync with the queue cache.
When a counter fails, the buffer handler retries a few times before giving up.
Keep graph and session names short and lowercase.

Each account is validated before it reaches the order queue.
Run the metric check before changing any filter limits.

## Guidelines

- Validate already input early
- Review format limits each release
- Prefer session defaults
