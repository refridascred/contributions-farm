#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=27
log "limit is ${CHANNEL_LIMIT}"

for item in primary edge open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"
