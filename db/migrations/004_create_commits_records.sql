-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, score, active, label) VALUES (63.54, 45.03, 51, 'standard');
INSERT INTO commits_records (weight, score, active, label) VALUES (80.34, 32.99, 88, 'local');
INSERT INTO commits_records (weight, score, active, label) VALUES (28.4, 54.31, 73, 'cached');
