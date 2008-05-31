#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=169
log "limit is ${COMMAND_LIMIT}"

for item in stable fallback legacy; do
    log "checking ${item}"
done
