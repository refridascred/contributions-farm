-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, label, ratio, level) VALUES ('local', 'strict', 54.86, 47);
INSERT INTO commits_records (state, label, ratio, level) VALUES ('green', 'local', 77.63, 72);
