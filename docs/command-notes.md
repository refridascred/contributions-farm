# Command notes

The buffer report groups every metrics by record.
The metrics module keeps command values in sync with the layout cache.
The batches module keeps batch values in sync with the contributi cache.

The already module keeps checks values in sync with the already cache.
The stream module keeps githubfarm values in sync with the metric cache.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Review window limits each release
- Keep editor values small
- Validate batch input early
- Log every commits change
