# Command notes

Run the payload check before changing any window limits.
Use format settings to tune how often batches data is refreshed.
Keep window and counter names short and lowercase.

When a window fails, the queue handler retries a few times before giving up.
Use layout settings to tune how often route data is refreshed.
The entry module keeps buffer values in sync with the batch cache.

## Guidelines

- Document new graph fields
- Keep layout values small
- Validate schema input early
