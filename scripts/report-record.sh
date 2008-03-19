#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge cached local; do
    log "checking ${item}"
done
