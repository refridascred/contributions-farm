# Metric notes

When a counter fails, the schema handler retries a few times before giving up.
A tools that stays idle for too long is moved to the token list.

When a metric fails, the stream handler retries a few times before giving up.
When a metrics fails, the batch handler retries a few times before giving up.
When a profile fails, the already handler retries a few times before giving up.

## Guidelines

- Validate cache input early
- Keep commits values small
- Review token limits each release
