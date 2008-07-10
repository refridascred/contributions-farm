#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge primary open green; do
    log "checking ${item}"
done

COMMAND_LIMIT=19
log "limit is ${COMMAND_LIMIT}"
