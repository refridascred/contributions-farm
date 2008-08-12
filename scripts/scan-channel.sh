#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=170
log "limit is ${CHANNEL_LIMIT}"

for item in fallback primary open latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"
