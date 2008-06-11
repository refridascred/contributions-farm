-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, level, label, count) VALUES (83.74, 27, 'staging', 62);
INSERT INTO commits_records (ratio, level, label, count) VALUES (49.07, 64, 'fallback', 60);
INSERT INTO commits_records (ratio, level, label, count) VALUES (93.34, 3, 'green', 99);
