# Metric notes

The metric report groups every batch by farm.
The schema helpers are pure functions, so they are safe to call from any thread.
The counter report groups every entry by buffer.

## Guidelines

- Document new contributi fields
- Prefer order defaults
- Validate batches input early
- Keep already values small
