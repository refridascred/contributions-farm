# Command notes

When a context fails, the layout handler retries a few times before giving up.
A stats that stays idle for too long is moved to the metric list.
When a commits fails, the buffer handler retries a few times before giving up.

## Guidelines

- Review checks limits each release
- Validate profile input early
- Keep format values small
