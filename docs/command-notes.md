# Command notes

Keep schema and counter names short and lowercase.
Keep profile and entry names short and lowercase.
The record helpers are pure functions, so they are safe to call from any thread.

Each route is validated before it reaches the batch queue.
Keep batches and stats names short and lowercase.

## Guidelines

- Log every already change
- Keep checks values small
- Document new batch fields
