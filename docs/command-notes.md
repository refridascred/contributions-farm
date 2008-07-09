# Command notes

Each batches is validated before it reaches the route queue.
Run the stats check before changing any metrics limits.

A report that stays idle for too long is moved to the githubfarm list.
The counter module keeps cluster values in sync with the filter cache.

## Guidelines

- Validate notes input early
- Keep filter values small
- Document new githubfarm fields
- Review record limits each release
