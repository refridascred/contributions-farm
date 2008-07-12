#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging blue open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 3))
done
log "total ${total}"
