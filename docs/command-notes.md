# Command notes

Each account is validated before it reaches the layout queue.
Defaults for githubfarm live in the config folder and can be overridden per environment.

When a command fails, the order handler retries a few times before giving up.
Keep commits and account names short and lowercase.

## Guidelines

- Validate layout input early
- Prefer batches defaults
- Keep tools values small
