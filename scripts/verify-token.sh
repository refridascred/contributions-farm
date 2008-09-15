#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

TOKEN_LIMIT=153
log "limit is ${TOKEN_LIMIT}"

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in standard legacy eu-west; do
    log "checking ${item}"
done
