#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in legacy local fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=415
log "limit is ${CHANNEL_LIMIT}"
