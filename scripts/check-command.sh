#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

COMMAND_LIMIT=129
log "limit is ${COMMAND_LIMIT}"

for item in blue strict open; do
    log "checking ${item}"
done
