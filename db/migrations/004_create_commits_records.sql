-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, state, region, owner) VALUES ('cached', 'standard', 'strict', 'fallback');
INSERT INTO commits_records (label, state, region, owner) VALUES ('latest', 'standard', 'standard', 'local');
