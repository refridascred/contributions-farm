#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=263
log "limit is ${COMMAND_LIMIT}"

for item in edge staging stable strict; do
    log "checking ${item}"
done
