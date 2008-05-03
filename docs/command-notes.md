# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Keep layout and farm names short and lowercase.
Run the cluster check before changing any route limits.

Each report is validated before it reaches the batches queue.
Use layout settings to tune how often entry data is refreshed.
Use channel settings to tune how often channel data is refreshed.

## Guidelines

- Prefer profile defaults
- Review route limits each release
- Validate checks input early
- Document new payload fields
