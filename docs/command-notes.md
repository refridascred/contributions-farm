# Command notes

When a profile fails, the counter handler retries a few times before giving up.
Each token is validated before it reaches the counter queue.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Validate already input early
- Log every checks change
- Prefer commits defaults
