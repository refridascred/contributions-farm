#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=433
log "limit is ${COMMAND_LIMIT}"

for item in primary latest blue eu-west; do
    log "checking ${item}"
done
