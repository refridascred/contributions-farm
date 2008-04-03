#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=347
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"
