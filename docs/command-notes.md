# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
The command report groups every token by payload.
Run the record check before changing any command limits.

Each stats is validated before it reaches the notes queue.
The filter module keeps profile values in sync with the stream cache.
Each cache is validated before it reaches the editor queue.

## Guidelines

- Review payload limits each release
- Log every notes change
- Document new context fields
- Prefer cluster defaults
