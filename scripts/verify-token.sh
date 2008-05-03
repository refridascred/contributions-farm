#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

TOKEN_LIMIT=457
log "limit is ${TOKEN_LIMIT}"

for item in legacy latest; do
    log "checking ${item}"
done
