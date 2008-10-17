#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue stable primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=372
log "limit is ${COMMAND_LIMIT}"
