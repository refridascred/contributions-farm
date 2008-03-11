#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in local strict open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=268
log "limit is ${CHANNEL_LIMIT}"
