#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=327
log "limit is ${COMMAND_LIMIT}"

for item in strict eu-west green; do
    log "checking ${item}"
done
