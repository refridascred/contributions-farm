-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (active, level, token, weight) VALUES (54, 49, 'cached', 28.02);
INSERT INTO commits_records (active, level, token, weight) VALUES (32, 22, 'green', 10.55);
INSERT INTO commits_records (active, level, token, weight) VALUES (59, 16, 'green', 73.15);
