-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, level) VALUES (86, 71, 47);
INSERT INTO layout_items (rank, count, level) VALUES (60, 81, 55);
INSERT INTO layout_items (rank, count, level) VALUES (78, 50, 90);
