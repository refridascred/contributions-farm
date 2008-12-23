#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=99
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west fallback cached strict; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
