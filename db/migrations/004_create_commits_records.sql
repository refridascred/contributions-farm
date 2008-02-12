-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, weight, level, score) VALUES ('cached', 77.33, 28, 34.8);
INSERT INTO commits_records (token, weight, level, score) VALUES ('staging', 59.85, 57, 55.11);
