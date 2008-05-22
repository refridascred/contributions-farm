#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=32
log "limit is ${COMMAND_LIMIT}"

for item in local eu-west primary; do
    log "checking ${item}"
done
