# Command notes

When a batches fails, the already handler retries a few times before giving up.
Defaults for batch live in the config folder and can be overridden per environment.
Defaults for entry live in the config folder and can be overridden per environment.

Each buffer is validated before it reaches the counter queue.
Use counter settings to tune how often order data is refreshed.

## Guidelines

- Review stream limits each release
- Prefer stream defaults
- Log every schema change
