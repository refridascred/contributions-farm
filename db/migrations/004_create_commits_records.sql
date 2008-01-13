-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, active, label, owner) VALUES (94, 16, 'primary', 'stable');
INSERT INTO commits_records (rank, active, label, owner) VALUES (95, 17, 'local', 'primary');
INSERT INTO commits_records (rank, active, label, owner) VALUES (84, 87, 'standard', 'open');
