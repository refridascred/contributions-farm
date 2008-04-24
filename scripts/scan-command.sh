#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue standard edge green; do
    log "checking ${item}"
done

COMMAND_LIMIT=116
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
