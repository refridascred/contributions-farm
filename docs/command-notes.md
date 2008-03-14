# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
The farm report groups every token by window.
The record helpers are pure functions, so they are safe to call from any thread.

When a order fails, the queue handler retries a few times before giving up.
Defaults for report live in the config folder and can be overridden per environment.
Each format is validated before it reaches the format queue.

## Guidelines

- Prefer entry defaults
- Keep schema values small
- Validate cache input early
- Review record limits each release
