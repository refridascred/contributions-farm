#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest eu-west cached open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-stable}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
