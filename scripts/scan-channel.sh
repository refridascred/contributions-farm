#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open blue primary latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=339
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"
