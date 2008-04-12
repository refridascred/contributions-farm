# Command notes

Run the support check before changing any token limits.
The record helpers are pure functions, so they are safe to call from any thread.

When a notes fails, the layout handler retries a few times before giving up.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Prefer batches defaults
- Document new report fields
- Keep profile values small
