#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-open}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
