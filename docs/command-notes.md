# Command notes

Defaults for context live in the config folder and can be overridden per environment.
When a order fails, the graph handler retries a few times before giving up.
Each report is validated before it reaches the cache queue.

Run the window check before changing any batch limits.
Defaults for order live in the config folder and can be overridden per environment.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review schema limits each release
- Document new payload fields
- Validate notes input early
- Log every channel change
