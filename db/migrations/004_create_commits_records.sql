-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (token, score, level, region) VALUES ('local', 31.32, 8, 'fallback');
INSERT INTO commits_records (token, score, level, region) VALUES ('strict', 92.98, 52, 'eu-west');
