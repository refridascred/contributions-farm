# Command notes

The filter report groups every filter by command.
The account helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any entry limits.

Use filter settings to tune how often layout data is refreshed.
Each stats is validated before it reaches the order queue.
Run the metrics check before changing any channel limits.

## Guidelines

- Log every batches change
- Prefer tools defaults
- Document new farm fields
- Keep farm values small
