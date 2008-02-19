# Editor notes

The order helpers are pure functions, so they are safe to call from any thread.
Keep payload and contributi names short and lowercase.
Use channel settings to tune how often report data is refreshed.

The checks helpers are pure functions, so they are safe to call from any thread.
The report module keeps order values in sync with the command cache.

## Guidelines

- Keep farm values small
- Prefer support defaults
- Log every graph change
