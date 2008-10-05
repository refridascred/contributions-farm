#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=189
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west stable staging open; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
