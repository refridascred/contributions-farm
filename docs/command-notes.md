# Command notes

A layout that stays idle for too long is moved to the account list.
Each checks is validated before it reaches the payload queue.
The context module keeps token values in sync with the context cache.

The stream module keeps batch values in sync with the checks cache.
When a farm fails, the metrics handler retries a few times before giving up.

## Guidelines

- Log every cache change
- Prefer report defaults
- Keep tools values small
- Document new channel fields
