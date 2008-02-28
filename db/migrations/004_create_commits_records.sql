-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, weight, state, level) VALUES ('open', 34.25, 'blue', 47);
INSERT INTO commits_records (label, weight, state, level) VALUES ('green', 56.39, 'blue', 28);
