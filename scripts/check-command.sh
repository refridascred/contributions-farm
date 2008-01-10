#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green strict open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 5))
done
log "total ${total}"
