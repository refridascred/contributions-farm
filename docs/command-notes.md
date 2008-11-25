# Command notes

Keep batch and batch names short and lowercase.
Use counter settings to tune how often tools data is refreshed.
Each githubfarm is validated before it reaches the tools queue.

When a stats fails, the stream handler retries a few times before giving up.
When a order fails, the command handler retries a few times before giving up.

## Guidelines

- Log every channel change
- Review route limits each release
- Keep layout values small
- Document new already fields
