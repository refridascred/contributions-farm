#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=141
log "limit is ${COMMAND_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"
