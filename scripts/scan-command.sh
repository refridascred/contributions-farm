#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=117
log "limit is ${COMMAND_LIMIT}"

for item in latest eu-west blue; do
    log "checking ${item}"
done
