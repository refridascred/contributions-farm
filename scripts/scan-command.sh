#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green primary staging blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=90
log "limit is ${COMMAND_LIMIT}"
