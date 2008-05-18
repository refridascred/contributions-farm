#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict latest staging local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=460
log "limit is ${CHANNEL_LIMIT}"
