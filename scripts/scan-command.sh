#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=362
log "limit is ${COMMAND_LIMIT}"

for item in legacy open blue edge; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
