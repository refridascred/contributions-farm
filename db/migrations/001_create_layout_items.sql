-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, rank, ratio) VALUES (31, 36, 9.82);
INSERT INTO layout_items (active, rank, ratio) VALUES (30, 99, 74.75);
INSERT INTO layout_items (active, rank, ratio) VALUES (31, 40, 62.92);
