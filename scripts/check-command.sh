#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge green latest eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=457
log "limit is ${COMMAND_LIMIT}"
