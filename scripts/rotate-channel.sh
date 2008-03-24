#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in fallback edge stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=423
log "limit is ${CHANNEL_LIMIT}"
