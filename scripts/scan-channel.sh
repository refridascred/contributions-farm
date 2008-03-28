#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in blue fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=98
log "limit is ${CHANNEL_LIMIT}"
