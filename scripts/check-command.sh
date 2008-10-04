#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in eu-west local fallback green; do
    log "checking ${item}"
done

COMMAND_LIMIT=481
log "limit is ${COMMAND_LIMIT}"
