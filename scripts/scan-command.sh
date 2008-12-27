#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in edge stable eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=73
log "limit is ${COMMAND_LIMIT}"
