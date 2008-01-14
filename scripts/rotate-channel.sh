#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=120
log "limit is ${CHANNEL_LIMIT}"

for item in fallback staging; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"
