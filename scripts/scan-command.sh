#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary eu-west blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=74
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
