# Command notes

Keep stats and batches names short and lowercase.
When a graph fails, the layout handler retries a few times before giving up.
Run the stats check before changing any layout limits.

Each window is validated before it reaches the stats queue.
Use channel settings to tune how often stats data is refreshed.

## Guidelines

- Document new stats fields
- Keep graph values small
- Log every account change
- Review channel limits each release
