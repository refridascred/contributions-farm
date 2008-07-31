#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=91
log "limit is ${COMMAND_LIMIT}"

for item in latest open eu-west; do
    log "checking ${item}"
done
