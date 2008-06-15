#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=406
log "limit is ${COMMAND_LIMIT}"
