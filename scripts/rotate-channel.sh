#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict local primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=68
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 4))
done
log "total ${total}"
