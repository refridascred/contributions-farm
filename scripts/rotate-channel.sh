#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=458
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict standard fallback; do
    log "checking ${item}"
done
