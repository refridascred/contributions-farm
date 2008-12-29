#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=63
log "limit is ${CHANNEL_LIMIT}"

for item in staging latest; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
