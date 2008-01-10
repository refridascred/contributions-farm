# Command notes

The schema report groups every githubfarm by queue.
A layout that stays idle for too long is moved to the buffer list.

The checks report groups every batch by checks.
When a report fails, the stats handler retries a few times before giving up.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Review filter limits each release
- Log every githubfarm change
- Document new githubfarm fields
- Validate filter input early
