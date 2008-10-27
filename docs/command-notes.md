# Command notes

The checks module keeps profile values in sync with the record cache.
The schema module keeps route values in sync with the route cache.
Use queue settings to tune how often support data is refreshed.

Each route is validated before it reaches the token queue.
Use context settings to tune how often support data is refreshed.
The command report groups every filter by metric.

## Guidelines

- Document new batch fields
- Validate checks input early
- Log every cache change
- Review profile limits each release
