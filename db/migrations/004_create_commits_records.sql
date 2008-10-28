-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, level, active, label) VALUES (31.97, 25, 20, 'standard');
INSERT INTO commits_records (score, level, active, label) VALUES (48.11, 0, 30, 'cached');
INSERT INTO commits_records (score, level, active, label) VALUES (65.25, 90, 95, 'legacy');
