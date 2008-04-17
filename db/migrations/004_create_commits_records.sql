-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, rank, level, ratio, state) VALUES ('blue', 32, 89, 92.07, 'blue');
INSERT INTO commits_records (token, rank, level, ratio, state) VALUES ('green', 58, 45, 46.51, 'fallback');
