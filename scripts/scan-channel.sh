#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in fallback staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=257
log "limit is ${CHANNEL_LIMIT}"
