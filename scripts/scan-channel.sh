#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=21
log "limit is ${CHANNEL_LIMIT}"

for item in stable latest green staging; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
