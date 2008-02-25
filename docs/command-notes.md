# Command notes

The record module keeps metric values in sync with the graph cache.
Each buffer is validated before it reaches the record queue.

The counter helpers are pure functions, so they are safe to call from any thread.
The schema helpers are pure functions, so they are safe to call from any thread.
The contributi module keeps checks values in sync with the already cache.

## Guidelines

- Log every already change
- Document new stream fields
- Prefer metrics defaults
- Validate command input early
