# Command notes

The counter report groups every profile by metrics.
The route helpers are pure functions, so they are safe to call from any thread.
Defaults for filter live in the config folder and can be overridden per environment.

When a farm fails, the session handler retries a few times before giving up.
Run the layout check before changing any checks limits.

## Guidelines

- Prefer profile defaults
- Document new queue fields
- Review graph limits each release
- Keep entry values small
