-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, rank, ratio, region) VALUES ('local', 93, 5.01, 'fallback');
INSERT INTO commits_records (state, rank, ratio, region) VALUES ('local', 35, 95.55, 'stable');
INSERT INTO commits_records (state, rank, ratio, region) VALUES ('strict', 41, 38.13, 'standard');
