#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue green eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=249
log "limit is ${COMMAND_LIMIT}"
