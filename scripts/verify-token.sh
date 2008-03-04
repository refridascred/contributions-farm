#!/usr/bin/env bash
# Verify the token data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

TOKEN_LIMIT=403
log "limit is ${TOKEN_LIMIT}"

for item in primary latest stable; do
    log "checking ${item}"
done
