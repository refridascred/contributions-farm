#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=309
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

for item in local edge standard; do
    log "checking ${item}"
done
