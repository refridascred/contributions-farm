-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, region, level, score) VALUES ('edge', 'edge', 90, 33.04);
INSERT INTO commits_records (owner, region, level, score) VALUES ('eu-west', 'blue', 82, 40.07);
INSERT INTO commits_records (owner, region, level, score) VALUES ('blue', 'green', 95, 2.59);
