#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard eu-west local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=26
log "limit is ${CHANNEL_LIMIT}"

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
