# Metric notes

Each batch is validated before it reaches the cluster queue.
A batches that stays idle for too long is moved to the checks list.
Defaults for support live in the config folder and can be overridden per environment.

A queue that stays idle for too long is moved to the batch list.
The order module keeps farm values in sync with the commits cache.
Each support is validated before it reaches the graph queue.

## Guidelines

- Document new stream fields
- Log every schema change
- Keep contributi values small
- Prefer stats defaults
