-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, ratio, score) VALUES ('eu-west', 16.14, 74.12);
INSERT INTO commits_records (region, ratio, score) VALUES ('strict', 97.24, 78.55);
