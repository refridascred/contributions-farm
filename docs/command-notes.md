# Command notes

Run the stream check before changing any profile limits.
The order helpers are pure functions, so they are safe to call from any thread.

Run the stats check before changing any metric limits.
Keep contributi and channel names short and lowercase.
Use channel settings to tune how often cache data is refreshed.

## Guidelines

- Prefer window defaults
- Keep layout values small
- Log every editor change
- Review batches limits each release
