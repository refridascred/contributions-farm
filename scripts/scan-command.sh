#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=313
log "limit is ${COMMAND_LIMIT}"

for item in blue eu-west cached; do
    log "checking ${item}"
done
