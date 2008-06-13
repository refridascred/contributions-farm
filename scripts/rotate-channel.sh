#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in legacy green fallback edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=408
log "limit is ${CHANNEL_LIMIT}"
