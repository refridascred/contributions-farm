#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue green eu-west standard; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

mode="${1:-cached}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
