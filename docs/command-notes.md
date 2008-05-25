# Command notes

The account module keeps stream values in sync with the account cache.
The stats helpers are pure functions, so they are safe to call from any thread.
The tools module keeps tools values in sync with the queue cache.

## Guidelines

- Log every graph change
- Validate layout input early
- Prefer context defaults
