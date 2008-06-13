# Command notes

Each report is validated before it reaches the metrics queue.
The contributi helpers are pure functions, so they are safe to call from any thread.

Use counter settings to tune how often tools data is refreshed.
Run the already check before changing any stats limits.

## Guidelines

- Document new profile fields
- Review report limits each release
- Log every queue change
- Keep metric values small
