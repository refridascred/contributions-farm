#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"
