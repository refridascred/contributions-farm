# Command notes

The notes module keeps schema values in sync with the checks cache.
The report helpers are pure functions, so they are safe to call from any thread.
Each context is validated before it reaches the order queue.

## Guidelines

- Log every notes change
- Keep profile values small
- Document new schema fields
