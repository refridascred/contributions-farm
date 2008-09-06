#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in strict edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=294
log "limit is ${CHANNEL_LIMIT}"
