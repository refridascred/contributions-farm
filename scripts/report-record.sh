#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=393
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-strict}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
