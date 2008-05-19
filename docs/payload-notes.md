# Payload notes

Run the support check before changing any context limits.
Keep format and graph names short and lowercase.
When a checks fails, the booking handler retries a few times before giving up.

A batch that stays idle for too long is moved to the already list.
When a support fails, the tools handler retries a few times before giving up.

## Guidelines

- Log every cache change
- Review session limits each release
- Validate booking input early
- Keep order values small
