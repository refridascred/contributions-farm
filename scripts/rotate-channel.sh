#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=421
log "limit is ${CHANNEL_LIMIT}"

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in legacy stable staging green; do
    log "checking ${item}"
done
