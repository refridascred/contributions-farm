#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west primary blue strict; do
    log "checking ${item}"
done

RECORD_LIMIT=51
log "limit is ${RECORD_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
