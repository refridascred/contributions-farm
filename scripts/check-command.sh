#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=396
log "limit is ${COMMAND_LIMIT}"

for item in open blue latest local; do
    log "checking ${item}"
done
