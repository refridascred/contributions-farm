#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green staging eu-west latest; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 5))
done
log "total ${total}"
