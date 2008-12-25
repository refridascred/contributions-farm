#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue stable; do
    log "checking ${item}"
done

TOKEN_LIMIT=137
log "limit is ${TOKEN_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
