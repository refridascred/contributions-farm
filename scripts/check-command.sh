#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge standard local fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=81
log "limit is ${COMMAND_LIMIT}"
