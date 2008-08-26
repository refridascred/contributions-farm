# Command notes

Keep context and order names short and lowercase.
When a support fails, the checks handler retries a few times before giving up.
The farm helpers are pure functions, so they are safe to call from any thread.

Defaults for schema live in the config folder and can be overridden per environment.
The report report groups every context by batches.

## Guidelines

- Review metrics limits each release
- Prefer profile defaults
- Log every format change
- Document new order fields
