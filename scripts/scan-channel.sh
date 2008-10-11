#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=450
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west cached fallback strict; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
