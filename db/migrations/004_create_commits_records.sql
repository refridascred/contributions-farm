-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, ratio, score, label, level) VALUES ('strict', 12.87, 91.33, 'latest', 80);
