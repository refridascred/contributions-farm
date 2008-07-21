-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, score) VALUES (45.75, 14.38);
INSERT INTO commits_records (ratio, score) VALUES (49.45, 76.62);
INSERT INTO commits_records (ratio, score) VALUES (91.35, 62.68);
