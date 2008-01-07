# Editor notes

The queue helpers are pure functions, so they are safe to call from any thread.
Run the channel check before changing any schema limits.
A report that stays idle for too long is moved to the graph list.

## Guidelines

- Prefer context defaults
- Document new entry fields
- Log every buffer change
