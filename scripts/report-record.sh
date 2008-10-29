#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge stable; do
    log "checking ${item}"
done

RECORD_LIMIT=146
log "limit is ${RECORD_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
