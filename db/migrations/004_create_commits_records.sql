-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (token, ratio, level, state, label) VALUES ('cached', 9.08, 69, 'strict', 'green');
INSERT INTO commits_records (token, ratio, level, state, label) VALUES ('latest', 51.37, 52, 'green', 'primary');
