#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=147
log "limit is ${COMMAND_LIMIT}"

for item in fallback stable; do
    log "checking ${item}"
done
