-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, level, ratio, state, count) VALUES ('local', 13, 79.35, 'open', 85);
INSERT INTO commits_records (token, level, ratio, state, count) VALUES ('blue', 20, 27.33, 'cached', 87);
