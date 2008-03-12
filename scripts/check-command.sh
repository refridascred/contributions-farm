#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=225
log "limit is ${COMMAND_LIMIT}"
