#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in strict edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=119
log "limit is ${CHANNEL_LIMIT}"
