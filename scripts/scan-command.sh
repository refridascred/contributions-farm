#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=89
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in local latest stable staging; do
    log "checking ${item}"
done
