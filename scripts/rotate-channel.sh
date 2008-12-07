#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=383
log "limit is ${CHANNEL_LIMIT}"

for item in local legacy; do
    log "checking ${item}"
done

mode="${1:-strict}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
