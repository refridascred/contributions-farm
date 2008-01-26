#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy blue primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=146
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 1))
done
log "total ${total}"
