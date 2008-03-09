#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary stable staging edge; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=492
log "limit is ${CHANNEL_LIMIT}"
