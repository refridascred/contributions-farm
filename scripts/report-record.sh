#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy standard stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"
