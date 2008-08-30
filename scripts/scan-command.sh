#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=349
log "limit is ${COMMAND_LIMIT}"

for item in staging green local; do
    log "checking ${item}"
done
