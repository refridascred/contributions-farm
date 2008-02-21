-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, label, score, region) VALUES (66, 'green', 32.02, 'blue');
INSERT INTO commits_records (active, label, score, region) VALUES (48, 'staging', 7.67, 'stable');
INSERT INTO commits_records (active, label, score, region) VALUES (38, 'local', 38.8, 'green');
