-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, level) VALUES (72, 55, 38);
INSERT INTO layout_items (rank, count, level) VALUES (43, 80, 16);
INSERT INTO layout_items (rank, count, level) VALUES (4, 27, 52);
