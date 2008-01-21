#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge blue staging open; do
    log "checking ${item}"
done

RECORD_LIMIT=368
log "limit is ${RECORD_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
