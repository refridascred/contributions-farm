#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green primary eu-west open; do
    log "checking ${item}"
done

RECORD_LIMIT=349
log "limit is ${RECORD_LIMIT}"
