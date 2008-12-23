# Command notes

The buffer report groups every metrics by context.
When a report fails, the route handler retries a few times before giving up.

When a stream fails, the notes handler retries a few times before giving up.
When a format fails, the account handler retries a few times before giving up.

## Guidelines

- Review route limits each release
- Keep window values small
- Log every token change
