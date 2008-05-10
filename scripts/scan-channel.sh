#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict standard green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"

CHANNEL_LIMIT=30
log "limit is ${CHANNEL_LIMIT}"
