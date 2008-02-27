#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict staging green legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=152
log "limit is ${COMMAND_LIMIT}"
