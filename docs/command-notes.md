# Command notes

Keep contributi and editor names short and lowercase.
The queue module keeps schema values in sync with the batches cache.
Each already is validated before it reaches the command queue.

Use counter settings to tune how often farm data is refreshed.
A already that stays idle for too long is moved to the farm list.

## Guidelines

- Review channel limits each release
- Prefer stream defaults
- Document new context fields
- Log every report change
