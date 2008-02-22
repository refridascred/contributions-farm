#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=102
log "limit is ${COMMAND_LIMIT}"

for item in edge primary fallback green; do
    log "checking ${item}"
done
