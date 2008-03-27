-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, count, label, region) VALUES ('latest', 17, 'primary', 'fallback');
INSERT INTO commits_records (state, count, label, region) VALUES ('blue', 92, 'standard', 'blue');
