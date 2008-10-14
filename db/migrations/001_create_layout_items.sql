-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, count, ratio) VALUES (34, 21, 71.36);
INSERT INTO layout_items (rank, count, ratio) VALUES (56, 91, 87.51);
INSERT INTO layout_items (rank, count, ratio) VALUES (59, 53, 48.52);
