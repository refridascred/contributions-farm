# Command notes

Each record is validated before it reaches the metrics queue.
Run the stream check before changing any buffer limits.
The queue module keeps already values in sync with the commits cache.

Use metrics settings to tune how often record data is refreshed.
A context that stays idle for too long is moved to the token list.

## Guidelines

- Prefer queue defaults
- Document new metrics fields
- Keep batch values small
