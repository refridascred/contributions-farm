#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=361
log "limit is ${COMMAND_LIMIT}"

for item in edge local fallback staging; do
    log "checking ${item}"
done
