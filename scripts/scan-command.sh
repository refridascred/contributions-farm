#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west legacy stable primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=459
log "limit is ${COMMAND_LIMIT}"
