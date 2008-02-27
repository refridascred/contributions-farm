#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=73
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"
