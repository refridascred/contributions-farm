-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (region, score, level) VALUES ('strict', 21.12, 18);
INSERT INTO commits_records (region, score, level) VALUES ('cached', 89.33, 73);
INSERT INTO commits_records (region, score, level) VALUES ('blue', 67.16, 63);
