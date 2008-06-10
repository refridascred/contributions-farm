#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging blue open green; do
    log "checking ${item}"
done

COMMAND_LIMIT=6
log "limit is ${COMMAND_LIMIT}"
