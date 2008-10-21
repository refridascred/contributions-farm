# Command notes

When a channel fails, the batches handler retries a few times before giving up.
The batch module keeps record values in sync with the payload cache.
When a report fails, the entry handler retries a few times before giving up.

The report report groups every contributi by already.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new notes fields
- Log every filter change
- Keep command values small
- Prefer buffer defaults
