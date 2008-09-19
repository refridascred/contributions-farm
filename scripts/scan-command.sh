#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict eu-west green; do
    log "checking ${item}"
done

COMMAND_LIMIT=315
log "limit is ${COMMAND_LIMIT}"
