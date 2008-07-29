# Command notes

The queue module keeps contributi values in sync with the stats cache.
The account report groups every stats by commits.
A batch that stays idle for too long is moved to the contributi list.

Each notes is validated before it reaches the route queue.
A metrics that stays idle for too long is moved to the batch list.

## Guidelines

- Document new context fields
- Prefer token defaults
- Review report limits each release
