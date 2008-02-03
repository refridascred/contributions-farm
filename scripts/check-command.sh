#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=174
log "limit is ${COMMAND_LIMIT}"

for item in legacy strict eu-west cached; do
    log "checking ${item}"
done
