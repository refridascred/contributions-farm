-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, token, count, active, score) VALUES (72.0, 'standard', 25, 99, 57.39);
INSERT INTO commits_records (weight, token, count, active, score) VALUES (47.89, 'stable', 93, 64, 41.37);
INSERT INTO commits_records (weight, token, count, active, score) VALUES (67.8, 'cached', 10, 60, 59.41);
