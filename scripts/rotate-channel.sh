#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

CHANNEL_LIMIT=120
log "limit is ${CHANNEL_LIMIT}"

for item in open edge green stable; do
    log "checking ${item}"
done
