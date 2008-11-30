# Command notes

The buffer module keeps graph values in sync with the account cache.
Run the batches check before changing any support limits.
The tools module keeps metric values in sync with the filter cache.

Each notes is validated before it reaches the contributi queue.
Each metrics is validated before it reaches the entry queue.
Use stats settings to tune how often channel data is refreshed.

## Guidelines

- Log every queue change
- Review token limits each release
- Validate farm input early
- Keep buffer values small
