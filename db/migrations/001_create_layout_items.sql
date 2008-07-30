-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, owner, score, count, label) VALUES (4, 'staging', 90.16, 40, 'eu-west');
INSERT INTO layout_items (rank, owner, score, count, label) VALUES (82, 'open', 83.65, 25, 'blue');
