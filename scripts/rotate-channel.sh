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

CHANNEL_LIMIT=109
log "limit is ${CHANNEL_LIMIT}"

for item in open strict eu-west; do
    log "checking ${item}"
done
