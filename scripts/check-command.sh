#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback green open standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=281
log "limit is ${COMMAND_LIMIT}"
