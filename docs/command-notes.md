# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Each layout is validated before it reaches the counter queue.
Each cache is validated before it reaches the stats queue.

The payload report groups every batch by githubfarm.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer graph defaults
- Keep already values small
- Log every layout change
- Review record limits each release
