#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=473
log "limit is ${COMMAND_LIMIT}"

for item in latest strict legacy; do
    log "checking ${item}"
done
