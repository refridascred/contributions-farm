# Command notes

The filter report groups every metrics by farm.
The farm helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often stream data is refreshed.

The tools report groups every graph by batches.
Keep session and context names short and lowercase.
The schema module keeps tools values in sync with the session cache.

## Guidelines

- Log every payload change
- Prefer tools defaults
- Document new counter fields
