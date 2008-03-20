-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, label, ratio, state, weight) VALUES ('edge', 'eu-west', 38.98, 'open', 15.75);
INSERT INTO commits_records (token, label, ratio, state, weight) VALUES ('local', 'standard', 41.36, 'primary', 6.89);
