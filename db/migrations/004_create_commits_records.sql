-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, weight, state, ratio) VALUES ('edge', 38.14, 'latest', 24.54);
INSERT INTO commits_records (label, weight, state, ratio) VALUES ('open', 83.26, 'strict', 40.7);
INSERT INTO commits_records (label, weight, state, ratio) VALUES ('eu-west', 76.07, 'stable', 97.28);
