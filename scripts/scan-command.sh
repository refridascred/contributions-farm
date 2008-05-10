#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=137
log "limit is ${COMMAND_LIMIT}"

for item in green local blue fallback; do
    log "checking ${item}"
done
