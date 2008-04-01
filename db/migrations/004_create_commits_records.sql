-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, state, level, active, ratio) VALUES ('latest', 'local', 23, 11, 57.2);
INSERT INTO commits_records (token, state, level, active, ratio) VALUES ('blue', 'eu-west', 45, 37, 43.84);
INSERT INTO commits_records (token, state, level, active, ratio) VALUES ('standard', 'cached', 54, 60, 44.42);
