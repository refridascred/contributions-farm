#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=129
log "limit is ${COMMAND_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
