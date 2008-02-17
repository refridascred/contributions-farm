#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback strict stable latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=147
log "limit is ${COMMAND_LIMIT}"
