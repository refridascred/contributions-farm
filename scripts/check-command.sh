#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary cached blue latest; do
    log "checking ${item}"
done

mode="${1:-local}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
