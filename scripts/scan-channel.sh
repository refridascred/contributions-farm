#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west stable local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=210
log "limit is ${CHANNEL_LIMIT}"
