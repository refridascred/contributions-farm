#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=322
log "limit is ${CHANNEL_LIMIT}"

for item in strict staging standard edge; do
    log "checking ${item}"
done
