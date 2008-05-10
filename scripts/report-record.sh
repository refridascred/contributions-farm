#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in latest eu-west local; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
