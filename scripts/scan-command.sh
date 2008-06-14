#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard cached eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=449
log "limit is ${COMMAND_LIMIT}"
