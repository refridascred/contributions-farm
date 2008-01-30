#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open eu-west strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=327
log "limit is ${COMMAND_LIMIT}"
