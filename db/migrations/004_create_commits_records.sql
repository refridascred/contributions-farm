-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, score, label, region) VALUES (40, 59.43, 'stable', 'primary');
INSERT INTO commits_records (active, score, label, region) VALUES (55, 89.19, 'cached', 'fallback');
