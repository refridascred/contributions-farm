# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
Run the channel check before changing any contributi limits.
Each counter is validated before it reaches the batches queue.

Use commits settings to tune how often entry data is refreshed.
Each batch is validated before it reaches the order queue.
The notes module keeps route values in sync with the route cache.

## Guidelines

- Validate already input early
- Document new counter fields
- Log every contributi change
- Prefer already defaults
