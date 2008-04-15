# Command notes

The batches module keeps context values in sync with the support cache.
The queue helpers are pure functions, so they are safe to call from any thread.

A channel that stays idle for too long is moved to the context list.
A token that stays idle for too long is moved to the record list.
Use batch settings to tune how often report data is refreshed.

## Guidelines

- Document new metric fields
- Log every already change
- Keep stream values small
