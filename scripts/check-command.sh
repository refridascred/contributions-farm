#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=357
log "limit is ${COMMAND_LIMIT}"

for item in stable fallback; do
    log "checking ${item}"
done
