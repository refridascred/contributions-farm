#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge local strict legacy; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=41
log "limit is ${CHANNEL_LIMIT}"
