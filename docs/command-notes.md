# Command notes

Run the commits check before changing any metric limits.
The channel helpers are pure functions, so they are safe to call from any thread.
Use farm settings to tune how often batch data is refreshed.

## Guidelines

- Prefer context defaults
- Log every order change
- Validate batches input early
