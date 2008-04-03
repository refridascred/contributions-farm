-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, score, state, active, ratio) VALUES ('cached', 89.94, 'local', 52, 85.59);
INSERT INTO commits_records (token, score, state, active, ratio) VALUES ('open', 54.82, 'latest', 91, 44.82);
