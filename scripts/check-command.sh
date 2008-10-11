#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open strict local eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=370
log "limit is ${COMMAND_LIMIT}"
