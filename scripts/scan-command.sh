#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green local eu-west edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=330
log "limit is ${COMMAND_LIMIT}"
