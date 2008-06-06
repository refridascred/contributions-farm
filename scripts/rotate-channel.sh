#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local standard; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

CHANNEL_LIMIT=480
log "limit is ${CHANNEL_LIMIT}"
