-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, label, state, score) VALUES ('primary', 'eu-west', 'green', 34.91);
INSERT INTO commits_records (token, label, state, score) VALUES ('green', 'local', 'edge', 49.94);
INSERT INTO commits_records (token, label, state, score) VALUES ('blue', 'green', 'standard', 31.93);
