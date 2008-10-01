#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

TOKEN_LIMIT=84
log "limit is ${TOKEN_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in primary local stable; do
    log "checking ${item}"
done
