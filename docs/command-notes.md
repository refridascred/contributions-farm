# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
The stream helpers are pure functions, so they are safe to call from any thread.
The account module keeps cache values in sync with the account cache.

## Guidelines

- Prefer payload defaults
- Document new account fields
- Log every context change
