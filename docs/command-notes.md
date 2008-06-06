# Command notes

The editor module keeps buffer values in sync with the report cache.
The stream module keeps batches values in sync with the contributi cache.
Each buffer is validated before it reaches the session queue.

The report report groups every cluster by window.
The channel helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often graph data is refreshed.

## Guidelines

- Log every support change
- Validate token input early
- Document new counter fields
