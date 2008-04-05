#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=377
log "limit is ${RECORD_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green cached local eu-west; do
    log "checking ${item}"
done
