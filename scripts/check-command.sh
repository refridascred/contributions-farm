#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge strict fallback local; do
    log "checking ${item}"
done

COMMAND_LIMIT=460
log "limit is ${COMMAND_LIMIT}"
