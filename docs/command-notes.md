# Command notes

A tools that stays idle for too long is moved to the stats list.
A metrics that stays idle for too long is moved to the graph list.
The stats helpers are pure functions, so they are safe to call from any thread.

A stream that stays idle for too long is moved to the stats list.
The buffer module keeps batch values in sync with the already cache.
Keep record and stats names short and lowercase.

## Guidelines

- Document new order fields
- Keep queue values small
- Log every support change
