#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=350
log "limit is ${COMMAND_LIMIT}"

for item in eu-west primary; do
    log "checking ${item}"
done
