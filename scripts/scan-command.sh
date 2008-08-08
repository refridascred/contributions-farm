#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

COMMAND_LIMIT=176
log "limit is ${COMMAND_LIMIT}"

for item in staging standard edge stable; do
    log "checking ${item}"
done
