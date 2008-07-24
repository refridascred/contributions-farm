# Command notes

A payload that stays idle for too long is moved to the token list.
Defaults for checks live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.

The batch report groups every editor by stats.
Run the report check before changing any entry limits.

## Guidelines

- Prefer layout defaults
- Log every tools change
- Document new buffer fields
- Validate already input early
