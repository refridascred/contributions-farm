-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, ratio, state) VALUES ('latest', 12.13, 'fallback');
INSERT INTO commits_records (region, ratio, state) VALUES ('strict', 4.17, 'blue');
