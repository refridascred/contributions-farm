# Command notes

The commits module keeps metric values in sync with the notes cache.
Each batches is validated before it reaches the session queue.
Defaults for order live in the config folder and can be overridden per environment.

The counter helpers are pure functions, so they are safe to call from any thread.
The order module keeps account values in sync with the report cache.

## Guidelines

- Log every tools change
- Keep editor values small
- Validate notes input early
- Document new farm fields
