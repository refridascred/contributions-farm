#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in open green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=5
log "limit is ${CHANNEL_LIMIT}"
