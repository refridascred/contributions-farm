#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge blue open; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
