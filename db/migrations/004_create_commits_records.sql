-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, active, score, level) VALUES ('cached', 30, 59.7, 4);
INSERT INTO commits_records (token, active, score, level) VALUES ('primary', 90, 75.5, 46);
INSERT INTO commits_records (token, active, score, level) VALUES ('blue', 14, 39.31, 79);
