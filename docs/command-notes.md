# Command notes

The window report groups every metric by context.
Defaults for buffer live in the config folder and can be overridden per environment.

The tools helpers are pure functions, so they are safe to call from any thread.
Run the record check before changing any record limits.

## Guidelines

- Document new graph fields
- Log every stats change
- Validate filter input early
- Review notes limits each release
