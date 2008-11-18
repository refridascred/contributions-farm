#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green eu-west edge primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=180
log "limit is ${COMMAND_LIMIT}"
