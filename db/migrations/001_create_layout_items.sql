-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, ratio, count) VALUES (40, 17.59, 66);
INSERT INTO layout_items (rank, ratio, count) VALUES (59, 7.47, 17);
INSERT INTO layout_items (rank, ratio, count) VALUES (84, 80.62, 10);
