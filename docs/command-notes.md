# Command notes

Each commits is validated before it reaches the buffer queue.
Defaults for metrics live in the config folder and can be overridden per environment.
The metric report groups every editor by githubfarm.

The farm module keeps support values in sync with the order cache.
Defaults for payload live in the config folder and can be overridden per environment.
The buffer module keeps contributi values in sync with the payload cache.

## Guidelines

- Validate batches input early
- Keep commits values small
- Prefer githubfarm defaults
