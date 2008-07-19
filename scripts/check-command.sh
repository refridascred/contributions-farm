#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest strict legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=381
log "limit is ${COMMAND_LIMIT}"
