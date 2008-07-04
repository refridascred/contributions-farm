-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (state, token, ratio, level, weight) VALUES ('local', 'local', 23.95, 49, 84.47);
INSERT INTO commits_records (state, token, ratio, level, weight) VALUES ('local', 'strict', 95.14, 91, 67.55);
INSERT INTO commits_records (state, token, ratio, level, weight) VALUES ('latest', 'legacy', 95.42, 94, 47.13);
