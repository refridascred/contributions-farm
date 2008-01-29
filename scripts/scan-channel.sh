#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached staging fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=85
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"
