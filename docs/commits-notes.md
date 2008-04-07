# Commits notes

The account report groups every stream by tools.
The already module keeps already values in sync with the booking cache.
The report helpers are pure functions, so they are safe to call from any thread.

Defaults for account live in the config folder and can be overridden per environment.
Keep buffer and session names short and lowercase.
A window that stays idle for too long is moved to the support list.

## Guidelines

- Validate support input early
- Document new booking fields
- Prefer cluster defaults
