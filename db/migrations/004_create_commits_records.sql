-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, count, label, owner) VALUES (68.16, 76, 'edge', 'fallback');
INSERT INTO commits_records (ratio, count, label, owner) VALUES (22.89, 70, 'eu-west', 'stable');
INSERT INTO commits_records (ratio, count, label, owner) VALUES (85.13, 41, 'open', 'staging');
