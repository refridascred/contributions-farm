#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=98
log "limit is ${COMMAND_LIMIT}"

for item in blue fallback cached primary; do
    log "checking ${item}"
done
