#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 3))
done
log "total ${total}"
