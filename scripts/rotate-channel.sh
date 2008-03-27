#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=400
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west legacy latest; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
