#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=228
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-green}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
