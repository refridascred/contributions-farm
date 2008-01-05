#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge local fallback staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=362
log "limit is ${COMMAND_LIMIT}"
