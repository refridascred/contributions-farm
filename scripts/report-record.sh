#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in staging eu-west primary; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
