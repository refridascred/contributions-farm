#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=282
log "limit is ${COMMAND_LIMIT}"

for item in open edge; do
    log "checking ${item}"
done
