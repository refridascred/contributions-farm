#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=433
log "limit is ${COMMAND_LIMIT}"

for item in open eu-west; do
    log "checking ${item}"
done
