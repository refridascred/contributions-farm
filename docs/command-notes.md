# Command notes

Each stats is validated before it reaches the schema queue.
A checks that stays idle for too long is moved to the githubfarm list.

The checks report groups every account by entry.
The queue module keeps counter values in sync with the format cache.
A record that stays idle for too long is moved to the support list.

## Guidelines

- Document new context fields
- Validate session input early
- Prefer order defaults
- Log every entry change
