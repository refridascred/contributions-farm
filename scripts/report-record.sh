#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west local standard strict; do
    log "checking ${item}"
done

mode="${1:-latest}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"
