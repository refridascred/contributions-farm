# Command notes

The already report groups every token by order.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the cache check before changing any cluster limits.

## Guidelines

- Review counter limits each release
- Keep githubfarm values small
- Document new schema fields
- Validate metrics input early
