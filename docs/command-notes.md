# Command notes

The tools module keeps editor values in sync with the report cache.
The payload module keeps order values in sync with the notes cache.

The layout report groups every already by support.
The batches helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the batches queue.

## Guidelines

- Prefer contributi defaults
- Review filter limits each release
- Document new already fields
