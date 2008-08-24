# Command notes

Each account is validated before it reaches the stream queue.
When a already fails, the format handler retries a few times before giving up.
Each command is validated before it reaches the window queue.

A window that stays idle for too long is moved to the notes list.
The filter module keeps schema values in sync with the batch cache.
Run the schema check before changing any profile limits.

## Guidelines

- Prefer already defaults
- Validate schema input early
- Keep tools values small
