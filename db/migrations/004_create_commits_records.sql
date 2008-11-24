-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, region, ratio) VALUES ('staging', 'fallback', 34.5);
INSERT INTO commits_records (state, region, ratio) VALUES ('open', 'staging', 91.93);
