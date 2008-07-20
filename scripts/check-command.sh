#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=183
log "limit is ${COMMAND_LIMIT}"

for item in eu-west edge standard; do
    log "checking ${item}"
done
