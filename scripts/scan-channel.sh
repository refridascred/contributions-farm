#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=387
log "limit is ${CHANNEL_LIMIT}"

for item in primary cached open green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 3))
done
log "total ${total}"
