# Command notes

The entry report groups every already by payload.
Keep already and batches names short and lowercase.
Use queue settings to tune how often farm data is refreshed.

Each commits is validated before it reaches the githubfarm queue.
A contributi that stays idle for too long is moved to the schema list.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Prefer cache defaults
- Log every already change
- Review stats limits each release
