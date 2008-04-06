-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, level, active, token) VALUES (31.65, 38, 59, 'staging');
INSERT INTO commits_records (score, level, active, token) VALUES (52.5, 98, 98, 'local');
INSERT INTO commits_records (score, level, active, token) VALUES (87.57, 86, 67, 'standard');
