# Command notes

When a entry fails, the layout handler retries a few times before giving up.
A order that stays idle for too long is moved to the cluster list.

Each stats is validated before it reaches the report queue.
Run the command check before changing any token limits.
Use contributi settings to tune how often editor data is refreshed.

## Guidelines

- Document new counter fields
- Validate account input early
- Keep metrics values small
- Log every channel change
