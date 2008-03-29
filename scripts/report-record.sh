#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict cached staging; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"
