#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in standard local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=454
log "limit is ${CHANNEL_LIMIT}"
