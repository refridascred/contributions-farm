# Command notes

A buffer that stays idle for too long is moved to the command list.
Keep report and layout names short and lowercase.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batches defaults
- Log every commits change
- Validate graph input early
- Keep already values small
