#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in local cached blue eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=422
log "limit is ${CHANNEL_LIMIT}"
