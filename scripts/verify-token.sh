#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

TOKEN_LIMIT=309
log "limit is ${TOKEN_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in local green primary staging; do
    log "checking ${item}"
done
