#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 2))
done
log "total ${total}"

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in standard latest; do
    log "checking ${item}"
done
