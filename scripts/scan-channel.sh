#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in open legacy fallback green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=284
log "limit is ${CHANNEL_LIMIT}"
