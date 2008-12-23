-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (state, active, rank, weight, label) VALUES ('standard', 32, 67, 64.88, 'staging');
INSERT INTO commits_records (state, active, rank, weight, label) VALUES ('latest', 62, 83, 98.4, 'cached');
INSERT INTO commits_records (state, active, rank, weight, label) VALUES ('open', 64, 10, 68.79, 'staging');
