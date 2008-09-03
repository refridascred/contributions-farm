#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local legacy fallback primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=29
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
