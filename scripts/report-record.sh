#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=171
log "limit is ${RECORD_LIMIT}"

for item in strict standard legacy edge; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
