#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=313
log "limit is ${COMMAND_LIMIT}"

for item in blue strict; do
    log "checking ${item}"
done
