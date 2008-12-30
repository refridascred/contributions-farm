#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 5))
done
log "total ${total}"

CHANNEL_LIMIT=291
log "limit is ${CHANNEL_LIMIT}"

for item in standard stable eu-west fallback; do
    log "checking ${item}"
done
