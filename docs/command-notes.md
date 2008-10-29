# Command notes

The counter report groups every layout by session.
Run the metrics check before changing any report limits.
Each already is validated before it reaches the entry queue.

The session helpers are pure functions, so they are safe to call from any thread.
Keep already and order names short and lowercase.
Keep contributi and format names short and lowercase.

## Guidelines

- Document new already fields
- Prefer record defaults
- Keep command values small
- Validate queue input early
