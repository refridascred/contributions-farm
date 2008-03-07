#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in standard primary staging blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=331
log "limit is ${CHANNEL_LIMIT}"
