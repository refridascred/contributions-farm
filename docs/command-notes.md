# Command notes

Each farm is validated before it reaches the contributi queue.
A farm that stays idle for too long is moved to the queue list.

The order report groups every githubfarm by payload.
The format module keeps payload values in sync with the farm cache.
Each graph is validated before it reaches the context queue.

## Guidelines

- Log every stats change
- Prefer context defaults
- Document new session fields
- Review metrics limits each release
