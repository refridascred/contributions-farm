#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=382
log "limit is ${CHANNEL_LIMIT}"

for item in open fallback; do
    log "checking ${item}"
done
