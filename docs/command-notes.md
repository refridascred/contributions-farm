# Command notes

Keep cluster and farm names short and lowercase.
Run the metrics check before changing any support limits.

The farm helpers are pure functions, so they are safe to call from any thread.
When a batch fails, the editor handler retries a few times before giving up.

## Guidelines

- Prefer stream defaults
- Validate counter input early
- Document new filter fields
