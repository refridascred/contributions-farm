# Command notes

Use order settings to tune how often support data is refreshed.
Each record is validated before it reaches the cache queue.
Run the channel check before changing any filter limits.

Keep filter and order names short and lowercase.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review notes limits each release
- Keep record values small
- Log every token change
