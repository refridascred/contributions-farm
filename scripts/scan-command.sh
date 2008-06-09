#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in blue cached fallback staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=361
log "limit is ${COMMAND_LIMIT}"
