#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard cached blue latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
