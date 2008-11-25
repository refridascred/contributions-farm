# Command notes

When a queue fails, the schema handler retries a few times before giving up.
The buffer report groups every commits by command.

Keep layout and batch names short and lowercase.
When a profile fails, the queue handler retries a few times before giving up.

## Guidelines

- Validate stream input early
- Keep channel values small
- Review metric limits each release
