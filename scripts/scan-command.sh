#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=434
log "limit is ${COMMAND_LIMIT}"

for item in green stable edge; do
    log "checking ${item}"
done
