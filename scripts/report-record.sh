#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary legacy stable fallback; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"
