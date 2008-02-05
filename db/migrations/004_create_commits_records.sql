-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, label, region) VALUES ('cached', 'legacy', 'cached');
INSERT INTO commits_records (state, label, region) VALUES ('standard', 'staging', 'fallback');
