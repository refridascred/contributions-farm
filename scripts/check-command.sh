#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open standard blue strict; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 2))
done
log "total ${total}"
