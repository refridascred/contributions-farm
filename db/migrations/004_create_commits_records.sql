-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, level, weight, active) VALUES ('fallback', 61, 85.47, 55);
INSERT INTO commits_records (token, level, weight, active) VALUES ('latest', 12, 47.9, 66);
