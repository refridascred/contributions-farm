#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"

BUFFER_LIMIT=355
log "limit is ${BUFFER_LIMIT}"

for item in staging green stable legacy; do
    log "checking ${item}"
done
