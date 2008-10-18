#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge cached open eu-west; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"
