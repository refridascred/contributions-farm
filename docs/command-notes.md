# Command notes

Each account is validated before it reaches the metric queue.
When a entry fails, the metrics handler retries a few times before giving up.

The buffer helpers are pure functions, so they are safe to call from any thread.
Run the payload check before changing any metrics limits.
The context report groups every buffer by route.

## Guidelines

- Log every order change
- Prefer record defaults
- Keep cluster values small
- Review route limits each release
