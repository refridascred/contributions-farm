#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy open strict local; do
    log "checking ${item}"
done

COMMAND_LIMIT=481
log "limit is ${COMMAND_LIMIT}"
