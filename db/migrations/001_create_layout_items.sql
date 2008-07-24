-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, count, rank, weight) VALUES ('staging', 35, 18, 7.05);
INSERT INTO layout_items (token, count, rank, weight) VALUES ('strict', 10, 14, 82.8);
