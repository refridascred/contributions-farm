#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green legacy strict eu-west; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-staging}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
