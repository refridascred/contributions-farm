# Command notes

The stats module keeps stream values in sync with the window cache.
The contributi module keeps stream values in sync with the metrics cache.

Keep entry and tools names short and lowercase.
Run the context check before changing any buffer limits.
Each checks is validated before it reaches the window queue.

## Guidelines

- Validate commits input early
- Prefer context defaults
- Document new session fields
- Log every format change
