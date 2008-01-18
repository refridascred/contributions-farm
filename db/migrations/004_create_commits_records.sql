-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, state, label, owner) VALUES ('green', 'standard', 'edge', 'fallback');
INSERT INTO commits_records (region, state, label, owner) VALUES ('strict', 'green', 'primary', 'open');
INSERT INTO commits_records (region, state, label, owner) VALUES ('fallback', 'local', 'legacy', 'stable');
