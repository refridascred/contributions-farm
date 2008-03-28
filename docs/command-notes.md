# Command notes

Run the filter check before changing any cache limits.
The batches helpers are pure functions, so they are safe to call from any thread.
A notes that stays idle for too long is moved to the payload list.

A farm that stays idle for too long is moved to the report list.
Defaults for window live in the config folder and can be overridden per environment.
Each report is validated before it reaches the token queue.

## Guidelines

- Document new batches fields
- Validate tools input early
- Review record limits each release
- Prefer channel defaults
