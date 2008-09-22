#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=320
log "limit is ${COMMAND_LIMIT}"

for item in blue edge open green; do
    log "checking ${item}"
done
