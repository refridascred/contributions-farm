# Command notes

Run the metrics check before changing any buffer limits.
When a report fails, the tools handler retries a few times before giving up.
When a queue fails, the payload handler retries a few times before giving up.

The already report groups every route by window.
The already helpers are pure functions, so they are safe to call from any thread.
Keep window and checks names short and lowercase.

## Guidelines

- Document new stream fields
- Keep channel values small
- Review support limits each release
