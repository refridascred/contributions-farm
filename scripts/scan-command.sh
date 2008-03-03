#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=120
log "limit is ${COMMAND_LIMIT}"

for item in primary eu-west cached open; do
    log "checking ${item}"
done
