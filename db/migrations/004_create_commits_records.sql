-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, level, count, token, state) VALUES (69.35, 95, 32, 'open', 'primary');
INSERT INTO commits_records (weight, level, count, token, state) VALUES (49.39, 50, 64, 'open', 'strict');
INSERT INTO commits_records (weight, level, count, token, state) VALUES (38.27, 28, 91, 'latest', 'cached');
