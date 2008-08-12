-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, active, token, label) VALUES (72, 96, 'primary', 'fallback');
INSERT INTO commits_records (rank, active, token, label) VALUES (92, 67, 'blue', 'open');
INSERT INTO commits_records (rank, active, token, label) VALUES (7, 80, 'eu-west', 'edge');
