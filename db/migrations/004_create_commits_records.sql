-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, label, ratio, score) VALUES ('latest', 'primary', 21.62, 10.74);
