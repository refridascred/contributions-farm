# Command notes

Use batches settings to tune how often already data is refreshed.
A cache that stays idle for too long is moved to the editor list.

Run the buffer check before changing any record limits.
Use report settings to tune how often metrics data is refreshed.
Each counter is validated before it reaches the record queue.

## Guidelines

- Validate cache input early
- Log every payload change
- Review checks limits each release
- Prefer format defaults
