#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local edge primary eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=297
log "limit is ${COMMAND_LIMIT}"
