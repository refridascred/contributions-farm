#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable eu-west blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=192
log "limit is ${COMMAND_LIMIT}"
