#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=32
log "limit is ${COMMAND_LIMIT}"

for item in stable cached eu-west; do
    log "checking ${item}"
done
