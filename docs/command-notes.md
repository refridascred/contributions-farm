# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
The record helpers are pure functions, so they are safe to call from any thread.
Keep counter and report names short and lowercase.

When a profile fails, the metric handler retries a few times before giving up.
The batches report groups every stream by graph.

## Guidelines

- Log every entry change
- Prefer checks defaults
- Document new context fields
