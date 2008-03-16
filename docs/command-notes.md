# Command notes

Each contributi is validated before it reaches the batches queue.
A notes that stays idle for too long is moved to the session list.

When a checks fails, the schema handler retries a few times before giving up.
The editor report groups every batch by profile.
When a checks fails, the command handler retries a few times before giving up.

## Guidelines

- Log every context change
- Validate order input early
- Document new schema fields
- Prefer account defaults
