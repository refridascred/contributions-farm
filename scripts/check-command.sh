#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=67
log "limit is ${COMMAND_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"
