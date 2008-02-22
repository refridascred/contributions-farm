#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in cached eu-west legacy stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=442
log "limit is ${CHANNEL_LIMIT}"
