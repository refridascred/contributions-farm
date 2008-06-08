# Command notes

Each tools is validated before it reaches the report queue.
The account module keeps layout values in sync with the graph cache.
A batches that stays idle for too long is moved to the contributi list.

The channel report groups every buffer by session.
A queue that stays idle for too long is moved to the stats list.
Run the counter check before changing any report limits.

## Guidelines

- Validate metric input early
- Prefer session defaults
- Log every stats change
- Document new batch fields
