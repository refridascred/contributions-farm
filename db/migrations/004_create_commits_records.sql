-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, label, ratio) VALUES ('primary', 'latest', 57.54);
INSERT INTO commits_records (state, label, ratio) VALUES ('primary', 'stable', 93.8);
