#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 2))
done
log "total ${total}"
