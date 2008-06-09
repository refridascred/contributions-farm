# Command notes

Each stream is validated before it reaches the filter queue.
Defaults for queue live in the config folder and can be overridden per environment.

When a format fails, the githubfarm handler retries a few times before giving up.
When a notes fails, the tools handler retries a few times before giving up.
The tools report groups every batch by stream.

## Guidelines

- Document new account fields
- Validate already input early
- Prefer commits defaults
- Log every cluster change
