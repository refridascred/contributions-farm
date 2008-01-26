#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in fallback standard strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=20
log "limit is ${CHANNEL_LIMIT}"
