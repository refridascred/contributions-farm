-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, region, weight, score) VALUES ('standard', 'green', 12.2, 41.36);
INSERT INTO commits_records (owner, region, weight, score) VALUES ('blue', 'blue', 71.55, 30.79);
