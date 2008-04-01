#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=297
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
