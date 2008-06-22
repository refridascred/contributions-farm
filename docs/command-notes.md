# Command notes

The metrics module keeps session values in sync with the session cache.
Use queue settings to tune how often stats data is refreshed.

The account module keeps order values in sync with the commits cache.
The report module keeps contributi values in sync with the queue cache.

## Guidelines

- Prefer metrics defaults
- Document new filter fields
- Validate farm input early
- Keep filter values small
