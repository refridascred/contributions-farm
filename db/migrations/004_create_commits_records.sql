-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, token, level, active, score) VALUES (73.61, 'green', 4, 84, 43.17);
INSERT INTO commits_records (weight, token, level, active, score) VALUES (5.95, 'local', 23, 72, 65.48);
