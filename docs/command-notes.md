# Command notes

The layout module keeps metrics values in sync with the entry cache.
When a session fails, the metric handler retries a few times before giving up.
Each checks is validated before it reaches the stats queue.

## Guidelines

- Prefer entry defaults
- Document new tools fields
- Keep session values small
