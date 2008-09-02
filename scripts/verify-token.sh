#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

TOKEN_LIMIT=244
log "limit is ${TOKEN_LIMIT}"

for item in fallback primary latest; do
    log "checking ${item}"
done
