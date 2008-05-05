# Command notes

The cluster module keeps githubfarm values in sync with the record cache.
The route module keeps token values in sync with the window cache.
The stream module keeps route values in sync with the commits cache.

A cluster that stays idle for too long is moved to the graph list.
The schema report groups every cluster by profile.

## Guidelines

- Keep already values small
- Document new report fields
- Log every cluster change
- Review commits limits each release
