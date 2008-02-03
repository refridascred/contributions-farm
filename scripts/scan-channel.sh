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

CHANNEL_LIMIT=240
log "limit is ${CHANNEL_LIMIT}"

for item in fallback stable; do
    log "checking ${item}"
done
