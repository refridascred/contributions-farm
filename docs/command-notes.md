# Command notes

Use githubfarm settings to tune how often entry data is refreshed.
The notes module keeps metrics values in sync with the tools cache.
Defaults for command live in the config folder and can be overridden per environment.

The cluster report groups every graph by queue.
The githubfarm report groups every profile by record.

## Guidelines

- Log every cache change
- Keep cache values small
- Review stats limits each release
