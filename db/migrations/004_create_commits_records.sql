-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, state, ratio, count) VALUES ('primary', 'primary', 76.34, 69);
INSERT INTO commits_records (token, state, ratio, count) VALUES ('staging', 'stable', 30.73, 1);
INSERT INTO commits_records (token, state, ratio, count) VALUES ('edge', 'blue', 86.0, 37);
