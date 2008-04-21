-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, label, rank, weight, ratio) VALUES ('open', 'green', 45, 32.05, 82.1);
INSERT INTO commits_records (state, label, rank, weight, ratio) VALUES ('blue', 'standard', 37, 14.94, 65.67);
INSERT INTO commits_records (state, label, rank, weight, ratio) VALUES ('edge', 'open', 7, 72.33, 23.55);
