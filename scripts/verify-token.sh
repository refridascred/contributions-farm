#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 3))
done
log "total ${total}"

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in blue open standard primary; do
    log "checking ${item}"
done
