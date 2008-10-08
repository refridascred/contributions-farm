# Metric notes

Each checks is validated before it reaches the metric queue.
Use counter settings to tune how often editor data is refreshed.

The stream module keeps order values in sync with the order cache.
Defaults for metrics live in the config folder and can be overridden per environment.
Each context is validated before it reaches the checks queue.

## Guidelines

- Review command limits each release
- Log every filter change
- Prefer account defaults
