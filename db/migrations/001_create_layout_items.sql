-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, rank, token, ratio) VALUES (94.43, 86, 'strict', 81.85);
INSERT INTO layout_items (weight, rank, token, ratio) VALUES (47.57, 13, 'fallback', 64.74);
