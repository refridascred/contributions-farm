# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Keep counter and batches names short and lowercase.

Defaults for context live in the config folder and can be overridden per environment.
Keep buffer and cache names short and lowercase.

## Guidelines

- Document new batches fields
- Validate support input early
- Review format limits each release
- Keep layout values small
