#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary eu-west staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=94
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
