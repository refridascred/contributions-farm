#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy staging; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"
