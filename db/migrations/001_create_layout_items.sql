-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (active, ratio, rank) VALUES (31, 80.44, 16);
INSERT INTO layout_items (active, ratio, rank) VALUES (35, 13.11, 85);
INSERT INTO layout_items (active, ratio, rank) VALUES (44, 60.62, 43);
