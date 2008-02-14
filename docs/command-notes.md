# Command notes

Keep graph and profile names short and lowercase.
When a queue fails, the layout handler retries a few times before giving up.
The checks helpers are pure functions, so they are safe to call from any thread.

When a token fails, the session handler retries a few times before giving up.
Keep batch and account names short and lowercase.
Each metrics is validated before it reaches the schema queue.

## Guidelines

- Keep stats values small
- Log every token change
- Review profile limits each release
- Prefer schema defaults
