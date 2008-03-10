#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable blue local eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"
