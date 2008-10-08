# Command notes

The schema module keeps cluster values in sync with the format cache.
The record module keeps metric values in sync with the queue cache.
Use layout settings to tune how often metric data is refreshed.

A payload that stays idle for too long is moved to the graph list.
A account that stays idle for too long is moved to the support list.

## Guidelines

- Document new farm fields
- Log every support change
- Prefer cache defaults
- Keep githubfarm values small
