-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, label, region, count, owner) VALUES (35.09, 'latest', 'eu-west', 17, 'standard');
INSERT INTO commits_records (score, label, region, count, owner) VALUES (6.12, 'green', 'cached', 94, 'fallback');
