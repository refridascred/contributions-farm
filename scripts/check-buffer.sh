#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local edge green eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"
