-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, token, weight) VALUES (41, 'stable', 11.56);
INSERT INTO commits_records (level, token, weight) VALUES (65, 'blue', 83.95);
