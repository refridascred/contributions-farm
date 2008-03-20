#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue fallback local standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=181
log "limit is ${COMMAND_LIMIT}"
