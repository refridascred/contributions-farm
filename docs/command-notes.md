# Command notes

The counter module keeps route values in sync with the order cache.
The order helpers are pure functions, so they are safe to call from any thread.
Run the contributi check before changing any batches limits.

## Guidelines

- Keep checks values small
- Document new stats fields
- Prefer entry defaults
