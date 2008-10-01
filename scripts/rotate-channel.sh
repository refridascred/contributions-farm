#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in strict staging standard eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=8
log "limit is ${CHANNEL_LIMIT}"
