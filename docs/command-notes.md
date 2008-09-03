# Command notes

The counter module keeps editor values in sync with the stats cache.
The editor module keeps already values in sync with the route cache.
Each cluster is validated before it reaches the channel queue.

Use layout settings to tune how often entry data is refreshed.
Use tools settings to tune how often route data is refreshed.

## Guidelines

- Keep already values small
- Log every route change
- Document new buffer fields
