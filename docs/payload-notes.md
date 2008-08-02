# Payload notes

Keep context and already names short and lowercase.
The batches module keeps buffer values in sync with the report cache.

Run the report check before changing any record limits.
When a account fails, the queue handler retries a few times before giving up.

## Guidelines

- Log every cluster change
- Review channel limits each release
- Prefer metrics defaults
