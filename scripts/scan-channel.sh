#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=445
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"
