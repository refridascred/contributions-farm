# Command notes

Run the account check before changing any schema limits.
A entry that stays idle for too long is moved to the route list.
The channel module keeps stats values in sync with the schema cache.

Run the queue check before changing any token limits.
Use tools settings to tune how often channel data is refreshed.
Each checks is validated before it reaches the batch queue.

## Guidelines

- Review route limits each release
- Validate format input early
- Prefer contributi defaults
- Log every context change
