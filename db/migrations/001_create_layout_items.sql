-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, level, score) VALUES (72, 28, 38.96);
INSERT INTO layout_items (rank, level, score) VALUES (25, 6, 83.17);
INSERT INTO layout_items (rank, level, score) VALUES (27, 40, 75.68);
