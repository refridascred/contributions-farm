-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, rank, label) VALUES (76.58, 20, 'fallback');
INSERT INTO commits_records (ratio, rank, label) VALUES (48.44, 68, 'fallback');
INSERT INTO commits_records (ratio, rank, label) VALUES (54.94, 32, 'legacy');
