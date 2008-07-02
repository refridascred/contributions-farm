#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=127
log "limit is ${COMMAND_LIMIT}"

for item in legacy staging blue; do
    log "checking ${item}"
done
