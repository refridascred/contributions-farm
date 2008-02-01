#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached primary strict fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=145
log "limit is ${COMMAND_LIMIT}"
