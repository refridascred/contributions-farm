-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (owner, region, score) VALUES ('strict', 'open', 61.67);
INSERT INTO commits_records (owner, region, score) VALUES ('cached', 'fallback', 37.74);
INSERT INTO commits_records (owner, region, score) VALUES ('primary', 'staging', 82.78);
