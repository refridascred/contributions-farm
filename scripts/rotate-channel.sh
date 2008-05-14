#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=471
log "limit is ${CHANNEL_LIMIT}"

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in strict open legacy fallback; do
    log "checking ${item}"
done
