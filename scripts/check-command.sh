#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=62
log "limit is ${COMMAND_LIMIT}"

for item in local staging open green; do
    log "checking ${item}"
done
