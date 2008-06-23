-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, score, owner) VALUES (73, 57.19, 'cached');
INSERT INTO layout_items (rank, score, owner) VALUES (21, 82.0, 'staging');
INSERT INTO layout_items (rank, score, owner) VALUES (43, 34.28, 'fallback');
