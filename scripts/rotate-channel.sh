#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=352
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue staging eu-west; do
    log "checking ${item}"
done
