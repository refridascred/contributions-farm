# Command notes

Keep buffer and queue names short and lowercase.
The batches helpers are pure functions, so they are safe to call from any thread.
Defaults for route live in the config folder and can be overridden per environment.

Keep account and channel names short and lowercase.
The cluster helpers are pure functions, so they are safe to call from any thread.
Use metrics settings to tune how often counter data is refreshed.

## Guidelines

- Review stats limits each release
- Document new report fields
- Validate command input early
- Log every report change
