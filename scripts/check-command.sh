#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=182
log "limit is ${COMMAND_LIMIT}"

for item in eu-west stable local; do
    log "checking ${item}"
done
