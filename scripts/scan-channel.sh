#!/usr/bin/env bash
# Scan the channel data.
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

for item in eu-west standard strict edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=101
log "limit is ${CHANNEL_LIMIT}"
