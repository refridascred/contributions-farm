#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=431
log "limit is ${CHANNEL_LIMIT}"

for item in open green cached; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"
