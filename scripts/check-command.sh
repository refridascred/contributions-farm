#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local primary edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=127
log "limit is ${COMMAND_LIMIT}"
