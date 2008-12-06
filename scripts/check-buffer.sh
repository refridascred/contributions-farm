#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard green edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 1))
done
log "total ${total}"
