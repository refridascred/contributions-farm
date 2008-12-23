# Command notes

The farm module keeps support values in sync with the contributi cache.
A stats that stays idle for too long is moved to the context list.
The counter report groups every order by batch.

Use window settings to tune how often githubfarm data is refreshed.
Each filter is validated before it reaches the batches queue.

## Guidelines

- Validate graph input early
- Log every order change
- Review schema limits each release
