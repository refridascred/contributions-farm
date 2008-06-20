#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=345
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
