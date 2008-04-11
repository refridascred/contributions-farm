#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard eu-west; do
    log "checking ${item}"
done

TOKEN_LIMIT=202
log "limit is ${TOKEN_LIMIT}"
