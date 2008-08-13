# Command notes

Use stream settings to tune how often report data is refreshed.
The order helpers are pure functions, so they are safe to call from any thread.
The filter report groups every report by command.

A metrics that stays idle for too long is moved to the cluster list.
The tools report groups every already by batches.
Run the metrics check before changing any window limits.

## Guidelines

- Keep channel values small
- Prefer filter defaults
- Document new profile fields
- Validate profile input early
