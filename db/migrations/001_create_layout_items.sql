-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, rank, token, label, score) VALUES (24.16, 72, 'stable', 'open', 44.24);
INSERT INTO layout_items (ratio, rank, token, label, score) VALUES (33.72, 77, 'open', 'staging', 96.2);
INSERT INTO layout_items (ratio, rank, token, label, score) VALUES (94.71, 75, 'fallback', 'green', 45.45);
