#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=453
log "limit is ${COMMAND_LIMIT}"

for item in eu-west staging; do
    log "checking ${item}"
done
