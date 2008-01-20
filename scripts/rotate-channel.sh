#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=195
log "limit is ${CHANNEL_LIMIT}"

for item in standard blue stable; do
    log "checking ${item}"
done
