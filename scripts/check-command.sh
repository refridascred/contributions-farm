#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=179
log "limit is ${COMMAND_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
