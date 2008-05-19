-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, label, count, region) VALUES (20.76, 'local', 78, 'standard');
INSERT INTO commits_records (ratio, label, count, region) VALUES (55.08, 'legacy', 11, 'fallback');
