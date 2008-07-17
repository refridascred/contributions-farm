# Command notes

Keep layout and already names short and lowercase.
The record module keeps account values in sync with the filter cache.

Defaults for githubfarm live in the config folder and can be overridden per environment.
Each metrics is validated before it reaches the report queue.
A graph that stays idle for too long is moved to the batch list.

## Guidelines

- Log every metrics change
- Keep graph values small
- Review record limits each release
- Validate batch input early
