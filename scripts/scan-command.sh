#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=84
log "limit is ${COMMAND_LIMIT}"

for item in eu-west fallback; do
    log "checking ${item}"
done
