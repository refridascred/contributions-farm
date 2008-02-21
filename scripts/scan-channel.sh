#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached green stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

CHANNEL_LIMIT=228
log "limit is ${CHANNEL_LIMIT}"
