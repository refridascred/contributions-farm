#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue cached; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
