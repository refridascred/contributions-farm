#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard primary legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"
