#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=305
log "limit is ${COMMAND_LIMIT}"

for item in primary local; do
    log "checking ${item}"
done
