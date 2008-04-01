#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy strict staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=218
log "limit is ${COMMAND_LIMIT}"
