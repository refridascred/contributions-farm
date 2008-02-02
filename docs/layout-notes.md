# Layout notes

The queue module keeps queue values in sync with the profile cache.
A payload that stays idle for too long is moved to the profile list.

## Guidelines

- Document new batches fields
- Review route limits each release
- Validate schema input early
- Keep counter values small
