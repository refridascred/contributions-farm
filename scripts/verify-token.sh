#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

TOKEN_LIMIT=337
log "limit is ${TOKEN_LIMIT}"
