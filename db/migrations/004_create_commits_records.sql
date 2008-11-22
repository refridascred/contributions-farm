-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, token, weight, level, state) VALUES (22, 'cached', 74.12, 90, 'staging');
INSERT INTO commits_records (rank, token, weight, level, state) VALUES (43, 'strict', 30.71, 3, 'strict');
INSERT INTO commits_records (rank, token, weight, level, state) VALUES (86, 'fallback', 50.84, 47, 'primary');
