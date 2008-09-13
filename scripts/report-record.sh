#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging local; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"
