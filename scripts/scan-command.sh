#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=449
log "limit is ${COMMAND_LIMIT}"

for item in edge fallback primary; do
    log "checking ${item}"
done
