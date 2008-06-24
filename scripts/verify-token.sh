#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached stable; do
    log "checking ${item}"
done

TOKEN_LIMIT=28
log "limit is ${TOKEN_LIMIT}"
