# Command notes

The schema module keeps buffer values in sync with the editor cache.
When a metrics fails, the window handler retries a few times before giving up.
When a schema fails, the context handler retries a few times before giving up.

## Guidelines

- Keep filter values small
- Document new checks fields
- Validate graph input early
- Prefer schema defaults
