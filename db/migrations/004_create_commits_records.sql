-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, score, weight, active, owner) VALUES ('strict', 83.24, 93.56, 90, 'primary');
INSERT INTO commits_records (token, score, weight, active, owner) VALUES ('edge', 58.35, 0.83, 85, 'open');
