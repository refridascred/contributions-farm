#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in strict local green standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=39
log "limit is ${CHANNEL_LIMIT}"
