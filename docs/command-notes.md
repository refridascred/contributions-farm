# Command notes

A commits that stays idle for too long is moved to the command list.
The report helpers are pure functions, so they are safe to call from any thread.

The tools module keeps queue values in sync with the batches cache.
A buffer that stays idle for too long is moved to the graph list.

## Guidelines

- Review context limits each release
- Log every stats change
- Keep editor values small
- Validate metric input early
