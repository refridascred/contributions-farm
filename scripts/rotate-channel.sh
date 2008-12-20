#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

CHANNEL_LIMIT=199
log "limit is ${CHANNEL_LIMIT}"

for item in local cached edge fallback; do
    log "checking ${item}"
done
