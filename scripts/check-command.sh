#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=475
log "limit is ${COMMAND_LIMIT}"

for item in legacy standard edge staging; do
    log "checking ${item}"
done
