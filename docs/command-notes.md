# Command notes

The report module keeps graph values in sync with the queue cache.
Each record is validated before it reaches the record queue.

The tools report groups every layout by editor.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every stream change
- Document new checks fields
- Validate editor input early
- Prefer cache defaults
