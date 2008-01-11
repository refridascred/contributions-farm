# Command notes

Run the route check before changing any session limits.
Keep stats and buffer names short and lowercase.

When a report fails, the githubfarm handler retries a few times before giving up.
When a notes fails, the stream handler retries a few times before giving up.
A stream that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Validate metrics input early
- Log every account change
- Keep githubfarm values small
