-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, score, label, level, region) VALUES (75, 87.22, 'cached', 57, 'edge');
INSERT INTO commits_records (rank, score, label, level, region) VALUES (99, 68.75, 'staging', 60, 'cached');
