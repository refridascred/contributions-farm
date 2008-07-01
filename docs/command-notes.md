# Command notes

Each metric is validated before it reaches the graph queue.
The stream module keeps stream values in sync with the metric cache.
A graph that stays idle for too long is moved to the metrics list.

Keep stream and farm names short and lowercase.
Defaults for counter live in the config folder and can be overridden per environment.
Each notes is validated before it reaches the contributi queue.

## Guidelines

- Validate profile input early
- Document new filter fields
- Review order limits each release
