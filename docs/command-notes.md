# Command notes

Keep cache and schema names short and lowercase.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

Run the cluster check before changing any layout limits.
Each already is validated before it reaches the order queue.

## Guidelines

- Validate metric input early
- Document new cache fields
- Review counter limits each release
