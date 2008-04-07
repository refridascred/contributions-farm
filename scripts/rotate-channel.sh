#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west cached standard latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=71
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
