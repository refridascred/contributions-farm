-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, token, ratio, label, rank) VALUES ('blue', 'fallback', 24.74, 'eu-west', 7);
INSERT INTO commits_records (state, token, ratio, label, rank) VALUES ('cached', 'standard', 25.68, 'strict', 95);
