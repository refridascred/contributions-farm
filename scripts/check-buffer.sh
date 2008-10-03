#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in strict standard blue staging; do
    log "checking ${item}"
done
