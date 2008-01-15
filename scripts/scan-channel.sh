#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback eu-west standard latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=382
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
