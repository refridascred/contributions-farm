#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

TOKEN_LIMIT=88
log "limit is ${TOKEN_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
