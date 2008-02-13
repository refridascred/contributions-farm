#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green fallback; do
    log "checking ${item}"
done

TOKEN_LIMIT=234
log "limit is ${TOKEN_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"
