# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Keep farm and context names short and lowercase.

Keep already and profile names short and lowercase.
A contributi that stays idle for too long is moved to the batch list.
A cache that stays idle for too long is moved to the context list.

## Guidelines

- Document new order fields
- Validate entry input early
- Prefer cache defaults
