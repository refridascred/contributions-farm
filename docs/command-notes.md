# Command notes

The farm module keeps route values in sync with the support cache.
Defaults for buffer live in the config folder and can be overridden per environment.
Each commits is validated before it reaches the route queue.

Use already settings to tune how often graph data is refreshed.
The account module keeps batch values in sync with the farm cache.
The stream module keeps token values in sync with the stats cache.

## Guidelines

- Keep batches values small
- Log every tools change
- Review token limits each release
