# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
Run the checks check before changing any layout limits.

Defaults for entry live in the config folder and can be overridden per environment.
Use stream settings to tune how often order data is refreshed.
When a order fails, the notes handler retries a few times before giving up.

## Guidelines

- Log every metric change
- Validate support input early
- Prefer githubfarm defaults
