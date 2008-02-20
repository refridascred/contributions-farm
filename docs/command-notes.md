# Command notes

Run the report check before changing any cache limits.
Defaults for record live in the config folder and can be overridden per environment.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review report limits each release
- Prefer context defaults
- Log every cluster change
