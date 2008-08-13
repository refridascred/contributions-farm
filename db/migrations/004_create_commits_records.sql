-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, token, weight) VALUES (10, 'blue', 36.39);
INSERT INTO commits_records (level, token, weight) VALUES (81, 'green', 5.29);
