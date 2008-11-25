-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (count, token, level, weight) VALUES (42, 'primary', 73, 8.98);
INSERT INTO commits_records (count, token, level, weight) VALUES (89, 'green', 21, 65.49);
INSERT INTO commits_records (count, token, level, weight) VALUES (35, 'latest', 76, 97.63);
