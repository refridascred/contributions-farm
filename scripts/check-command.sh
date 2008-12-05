#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local fallback latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=147
log "limit is ${COMMAND_LIMIT}"
